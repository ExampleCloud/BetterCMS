﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SavePageContentOptionsCommandTest.cs" company="Devbridge Group LLC">
// 
// Copyright (C) 2015,2016 Devbridge Group LLC
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/. 
// </copyright>
// 
// <summary>
// Better CMS is a publishing focused and developer friendly .NET open source CMS.
// 
// Website: https://www.bettercms.com 
// GitHub: https://github.com/devbridge/bettercms
// Email: info@bettercms.com
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System.Collections.Generic;
using System.Linq;

using Autofac;

using BetterModules.Core.DataAccess;
using BetterModules.Core.DataAccess.DataContext;
using BetterCms.Core.DataContracts.Enums;
using BetterCms.Module.Pages.Command.Content.SavePageContentOptions;
using BetterCms.Module.Pages.ViewModels.Content;
using BetterCms.Module.Root.Models;
using BetterCms.Module.Root.Services;
using BetterCms.Module.Root.ViewModels.Option;

using BetterModules.Core.Web.Services.Caching;

using NUnit.Framework;

namespace BetterCms.Test.Module.Pages.CommandTests.ContentTests
{
    [TestFixture]
    public class SavePageContentOptionsCommandTest : GetPageContentOptionsTest
    {
        [Test]
        public void Should_Save_Page_Content_Options_Successfully()
        {
            RunActionInTransaction(session =>
            {
                // Create page content with options
                var content = TestDataProvider.CreateNewContent();
                var pageContent = TestDataProvider.CreateNewPageContent(content);
                FillContentWithOptions(content);
                FillPageContentWithOptions(content, pageContent);

                session.SaveOrUpdate(pageContent);
                session.Flush();
                session.Clear();

                // Random option value
                var randomOptionValue = TestDataProvider.CreateNewPageContentOption();

                // Create request
                var request = new ContentOptionValuesViewModel
                    {
                        OptionValues = new List<OptionValueEditViewModel>
                            {
                                  new OptionValueEditViewModel
                                      {
                                          // Must be updated
                                          OptionKey = pageContent.Options[0].Key,
                                          OptionValue = content.ContentOptions[0].DefaultValue,
                                          UseDefaultValue = false
                                      },
                                  new OptionValueEditViewModel
                                      {
                                          // Must be deleted
                                          OptionKey = pageContent.Options[1].Key,
                                          OptionValue = null,
                                          UseDefaultValue = true
                                      },
                                  new OptionValueEditViewModel
                                      {
                                          // Must be updated
                                          OptionKey = pageContent.Options[2].Key,
                                          OptionValue = null,
                                          UseDefaultValue = false
                                      },
                                  new OptionValueEditViewModel
                                      {
                                          // Must be created
                                          OptionValue = randomOptionValue.Value,
                                          OptionKey = randomOptionValue.Key,
                                          Type = OptionType.Text
                                      }

                            },
                        OptionValuesContainerId = pageContent.Id
                    };

                // Create command
                var unitOfWork = new DefaultUnitOfWork(session);
                var repository = new DefaultRepository(unitOfWork);
                var command = new SavePageContentOptionsCommand();
                command.UnitOfWork = unitOfWork;
                command.Repository = repository;
                command.OptionService = new DefaultOptionService(repository, new HttpRuntimeCacheService(), Container.Resolve<ICmsConfiguration>());
                var result = command.Execute(request);

                Assert.IsNotNull(result);
                Assert.Greater(result.PageContentVersion, pageContent.Version);

                // Check results: one of page content values must be deleted after save
                var results = repository
                    .AsQueryable<PageContentOption>(pco => pco.PageContent.Id == pageContent.Id
                        && !pco.IsDeleted
                        && !pco.PageContent.IsDeleted)
                    .ToList();
                Assert.AreEqual(results.Count, 3);
                Assert.IsNotNull(results.FirstOrDefault(pco => {
                    return pco.Key == pageContent.Options[0].Key && pco.Value == content.ContentOptions[0].DefaultValue;
                }));
                Assert.IsNotNull(results.FirstOrDefault(pco => {
                    return pco.Key == pageContent.Options[2].Key && pco.Value == null;
                }));
                Assert.IsNotNull(results.FirstOrDefault(pco => pco.Key == randomOptionValue.Key
                    && pco.Value == randomOptionValue.Value));
            });
        }
    }
}
