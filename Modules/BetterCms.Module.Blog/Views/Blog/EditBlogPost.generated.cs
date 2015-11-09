﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Blog\EditBlogPost.cshtml"
    using BetterCms.Core.DataContracts.Enums;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Blog\EditBlogPost.cshtml"
    using BetterCms.Module.Blog.Content.Resources;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Blog\EditBlogPost.cshtml"
    using BetterCms.Module.Blog.Controllers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Blog\EditBlogPost.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Blog\EditBlogPost.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Blog\EditBlogPost.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Views\Blog\EditBlogPost.cshtml"
    using BetterCms.Module.Root.Mvc;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Views\Blog\EditBlogPost.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Views\Blog\EditBlogPost.cshtml"
    using BetterCms.Module.Root.Mvc.UI;
    
    #line default
    #line hidden
    
    #line 10 "..\..\Views\Blog\EditBlogPost.cshtml"
    using BetterCms.Module.Root.ViewModels.Category;
    
    #line default
    #line hidden
    
    #line 11 "..\..\Views\Blog\EditBlogPost.cshtml"
    using BetterCms.Module.Root.ViewModels.Tags;
    
    #line default
    #line hidden
    
    #line 12 "..\..\Views\Blog\EditBlogPost.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Blog/EditBlogPost.cshtml")]
    public partial class _Views_Blog_EditBlogPost_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Blog.ViewModels.Blog.BlogPostViewModel>
    {
        public _Views_Blog_EditBlogPost_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 14 "..\..\Views\Blog\EditBlogPost.cshtml"
 if (Model == null)
{
    return;
}

            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Blog\EditBlogPost.cshtml"
  
    var canEdit = (ViewContext.Controller as CmsControllerBase).SecurityService.IsAuthorized(RootModuleConstants.UserRoles.EditContent);
    var tagsTemplateViewModel = new TagsTemplateViewModel
    {
        TooltipDescription = BlogGlobalization.EditBlogPost_Tags_Tooltip_Description
    };
    var categoriesTemplateViewModel = new CategoryTemplateViewModel
    {
        TooltipDescription = BlogGlobalization.EditBlogPost_Category_Tooltip_Description
    };

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"bcms-tab-header bcms-js-tab-header\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" class=\"bcms-tab-ui bcms-tab-item bcms-active\"");

WriteLiteral(" data-name=\"#bcms-tab-1\"");

WriteLiteral(">");

            
            #line 32 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                                            Write(BlogGlobalization.EditBlogPost_ContentTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        <a");

WriteLiteral(" class=\"bcms-tab-ui bcms-tab-item\"");

WriteLiteral(" data-name=\"#bcms-tab-2\"");

WriteLiteral(">");

            
            #line 33 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                                Write(BlogGlobalization.EditBlogPost_PropertiesTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </div>\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 38 "..\..\Views\Blog\EditBlogPost.cshtml"
Write(Html.TabbedContentMessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-window-tabbed-options\"");

WriteLiteral(">\r\n");

            
            #line 41 "..\..\Views\Blog\EditBlogPost.cshtml"
        
            
            #line default
            #line hidden
            
            #line 41 "..\..\Views\Blog\EditBlogPost.cshtml"
         if (Model.CurrentStatus == ContentStatus.Draft)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"bcms-messages-ui bcms-js-messages\"");

WriteLiteral(">\r\n                <ul");

WriteLiteral(" class=\"bcms-success-messages\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral("></ul>\r\n                <ul");

WriteLiteral(" class=\"bcms-info-messages\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral("></ul>\r\n                <ul");

WriteLiteral(" class=\"bcms-warning-messages\"");

WriteLiteral(">\r\n                    <li>\r\n                        <a");

WriteLiteral(" class=\"bcms-messages-close bcms-js-btn-close\"");

WriteLiteral(" id=\"bcms-addnewblog-closeinfomessage\"");

WriteLiteral(">");

            
            #line 48 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                                                                          Write(RootGlobalization.Button_Close);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

WriteLiteral("                        ");

            
            #line 49 "..\..\Views\Blog\EditBlogPost.cshtml"
                   Write(PagesGlobalization.EditPageContent_Messages_DraftStatusWarnMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 50 "..\..\Views\Blog\EditBlogPost.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\Blog\EditBlogPost.cshtml"
                         if (Model.HasPublishedContent && canEdit)
                        {
                            
            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\Blog\EditBlogPost.cshtml"
                       Write(Html.Raw(PagesGlobalization.EditPageContent_Messages_DraftStatusWarnMessage_Destroy));

            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                                                                                 
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </li>\r\n                </ul>\r\n                <ul");

WriteLiteral(" class=\"bcms-error-messages\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral("></ul>\r\n            </div>\r\n");

            
            #line 58 "..\..\Views\Blog\EditBlogPost.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 60 "..\..\Views\Blog\EditBlogPost.cshtml"
    
            
            #line default
            #line hidden
            
            #line 60 "..\..\Views\Blog\EditBlogPost.cshtml"
     using (Html.BeginForm<BlogController>(c => c.SaveBlogPost(null), FormMethod.Post, new { @id = "bcms-blog-post-form", @class = "bcms-ajax-form", data_readonly = Model.IsReadOnly.ToString().ToLower() }))
        {
        
            
            #line default
            #line hidden
            
            #line 62 "..\..\Views\Blog\EditBlogPost.cshtml"
   Write(Html.HiddenFor(model => model.Id, new { data_bind = "value: id()" }));

            
            #line default
            #line hidden
            
            #line 62 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                                             
        
            
            #line default
            #line hidden
            
            #line 63 "..\..\Views\Blog\EditBlogPost.cshtml"
   Write(Html.HiddenFor(model => model.Version, new { data_bind = "value: version()" }));

            
            #line default
            #line hidden
            
            #line 63 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                                                       
        
            
            #line default
            #line hidden
            
            #line 64 "..\..\Views\Blog\EditBlogPost.cshtml"
   Write(Html.HiddenFor(model => model.Image.ImageId, new { data_bind = "value: image().id()" }));

            
            #line default
            #line hidden
            
            #line 64 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                                                                
        
            
            #line default
            #line hidden
            
            #line 65 "..\..\Views\Blog\EditBlogPost.cshtml"
   Write(Html.HiddenFor(modal => modal.DesirableStatus, new { @class = "bcms-content-desirable-status" }));

            
            #line default
            #line hidden
            
            #line 65 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                                                                         
        
            
            #line default
            #line hidden
            
            #line 66 "..\..\Views\Blog\EditBlogPost.cshtml"
   Write(Html.HiddenFor(model => model.EditInSourceMode, new { @data_bind = "value: editInSourceMode()" }));

            
            #line default
            #line hidden
            
            #line 66 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                                                                          
        
            
            #line default
            #line hidden
            
            #line 67 "..\..\Views\Blog\EditBlogPost.cshtml"
   Write(Html.HiddenFor(modal => modal.IsUserConfirmed, new { @id = "bcms-user-confirmed-region-deletion" }));

            
            #line default
            #line hidden
            
            #line 67 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                                                                            
        
            
            #line default
            #line hidden
            
            #line 68 "..\..\Views\Blog\EditBlogPost.cshtml"
   Write(Html.HiddenFor(modal => modal.ContentTextMode, new { @id = "bcms-user-confirmed-region-deletion" }));

            
            #line default
            #line hidden
            
            #line 68 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                                                                            


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"bcms-tab-1\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-newcontent-top\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-input-field-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 73 "..\..\Views\Blog\EditBlogPost.cshtml"
               Write(Html.Tooltip(BlogGlobalization.EditBlogPost_Title_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 74 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                Write(BlogGlobalization.EditBlogPost_Title_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-input-box\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 76 "..\..\Views\Blog\EditBlogPost.cshtml"
                   Write(Html.TextBoxFor(m => m.Title, new { @class = "bcms-editor-field-box", @id = "bcms-editor-blog-title", @style = "width: 523px;" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 77 "..\..\Views\Blog\EditBlogPost.cshtml"
                   Write(Html.BcmsValidationMessageFor(m => m.Title));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"bcms-input-field-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 81 "..\..\Views\Blog\EditBlogPost.cshtml"
               Write(Html.Tooltip(BlogGlobalization.EditBlogPost_LiveDates_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 82 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                Write(BlogGlobalization.EditBlogPost_LiveFrom_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-date-input-box\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 84 "..\..\Views\Blog\EditBlogPost.cshtml"
                   Write(Html.DateTextBoxFor(model => model.LiveFromDate, Model.LiveFromDate, new Dictionary<string, object> { { "class", "bcms-editor-field-box bcms-datepicker" }, { "style", "width: 127px;" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 85 "..\..\Views\Blog\EditBlogPost.cshtml"
                   Write(Html.BcmsValidationMessageFor(m => m.LiveFromDate));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"bcms-input-field-holder\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 89 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                Write(BlogGlobalization.EditBlogPost_LiveTo_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-date-input-box\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 91 "..\..\Views\Blog\EditBlogPost.cshtml"
                   Write(Html.DateTextBoxFor(model => model.LiveToDate, Model.LiveToDate, new Dictionary<string, object> { { "class", "bcms-editor-field-box bcms-datepicker" }, { "style", "width: 127px;" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 92 "..\..\Views\Blog\EditBlogPost.cshtml"
                   Write(Html.BcmsValidationMessageFor(m => m.LiveToDate));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n");

WriteLiteral("            ");

            
            #line 97 "..\..\Views\Blog\EditBlogPost.cshtml"
       Write(Html.Partial("Partial/AddNewBlogEditPermalink"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(" id=\"bcms-blog-content-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 100 "..\..\Views\Blog\EditBlogPost.cshtml"
           Write(Html.Tooltip(BlogGlobalization.EditBlogPost_Content_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 101 "..\..\Views\Blog\EditBlogPost.cshtml"
                                            Write(BlogGlobalization.EditBlogPost_Content_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                ");

            
            #line 102 "..\..\Views\Blog\EditBlogPost.cshtml"
           Write(Html.TextAreaFor(model => model.Content, new { @id = "bcms-blogcontent" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

            
            #line 105 "..\..\Views\Blog\EditBlogPost.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"bcms-tab-2\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-blog-settings-holder\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 109 "..\..\Views\Blog\EditBlogPost.cshtml"
               Write(Html.Tooltip(BlogGlobalization.EditBlogPost_IntroText_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 110 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                Write(BlogGlobalization.EditBlogPost_IntroText_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-textarea-box\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 112 "..\..\Views\Blog\EditBlogPost.cshtml"
                   Write(Html.TextAreaFor(m => m.IntroText, new { @style = "height: 217px;", @class = "bcms-editor-field-area" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 113 "..\..\Views\Blog\EditBlogPost.cshtml"
                   Write(Html.BcmsValidationMessageFor(m => m.IntroText));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-page-images-holder\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 119 "..\..\Views\Blog\EditBlogPost.cshtml"
                   Write(Html.Tooltip(BlogGlobalization.EditBlogPost_FeaturedImage_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 120 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                    Write(BlogGlobalization.EditBlogPost_FeaturedImage_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-uploaded-image\"");

WriteLiteral(">\r\n                            <!-- ko if: image().url() -->\r\n                   " +
"         <a");

WriteLiteral(" class=\"bcms-remove-image\"");

WriteLiteral(" data-bind=\"");

            
            #line 123 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                                Write(canEdit ? "click: image().remove.bind(image())" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">");

            
            #line 123 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                                                                                                  Write(RootGlobalization.Button_Remove);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                            <a");

WriteLiteral(" data-bind=\"click: image().preview.bind(image())\"");

WriteLiteral(">\r\n                                <img");

WriteLiteral(" data-bind=\"attr: { src: image().thumbnailUrl(), alt: image().tooltip() }\"");

WriteLiteral(" />\r\n                            </a>\r\n                            <!-- /ko -->\r\n" +
"                        </div>\r\n                        <div");

WriteLiteral(" class=\"bcms-upload-info\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-upload-info-text\"");

WriteLiteral(">");

            
            #line 130 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                          Write(BlogGlobalization.EditBlogPost_FeaturedImage_Description);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                            <div");

WriteLiteral(" class=\"bcms-btn-small\"");

WriteLiteral(" data-bind=\"");

            
            #line 131 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                               Write(canEdit ? "click: image().select.bind(image())" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">");

            
            #line 131 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                                                                                                 Write(BlogGlobalization.EditBlogPost_SelectImage_Button_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        </div>\r\n                    </div>\r\n             " +
"   </div>\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 138 "..\..\Views\Blog\EditBlogPost.cshtml"
           Write(Html.Tooltip(BlogGlobalization.EditBlogPost_Author_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 139 "..\..\Views\Blog\EditBlogPost.cshtml"
                                            Write(BlogGlobalization.EditBlogPost_Author_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                ");

            
            #line 140 "..\..\Views\Blog\EditBlogPost.cshtml"
           Write(Html.DropDownListFor(model => model.AuthorId, Model.Authors.ToSelectList(Model.AuthorId), string.Empty, new { @class = "bcms-global-select", @style = "width: 245px;" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-categories-box-holder\"");

WriteLiteral(" data-bind=\"with: categories\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 144 "..\..\Views\Blog\EditBlogPost.cshtml"
           Write(Html.Partial("~/Areas/bcms-root/Views/Category/CategoriesTemplate.cshtml", categoriesTemplateViewModel));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-tags-box-holder\"");

WriteLiteral(" data-bind=\"with: tags\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 148 "..\..\Views\Blog\EditBlogPost.cshtml"
           Write(Html.Partial("~/Areas/bcms-root/Views/Tags/TagsTemplate.cshtml", tagsTemplateViewModel));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n\r\n");

            
            #line 151 "..\..\Views\Blog\EditBlogPost.cshtml"
            
            
            #line default
            #line hidden
            
            #line 151 "..\..\Views\Blog\EditBlogPost.cshtml"
             if (Model.ShowLanguages)
                {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 154 "..\..\Views\Blog\EditBlogPost.cshtml"
               Write(Html.Tooltip(BlogGlobalization.EditBlogPost_Language_Tooltip));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 155 "..\..\Views\Blog\EditBlogPost.cshtml"
                                                Write(BlogGlobalization.EditBlogPost_Language_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                    ");

            
            #line 156 "..\..\Views\Blog\EditBlogPost.cshtml"
               Write(Html.DropDownListFor(model => model.LanguageId, Model.Languages.ToSelectList(Model.LanguageId), "Default language", new { @class = "bcms-global-select", @style = "width: 245px;" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

            
            #line 158 "..\..\Views\Blog\EditBlogPost.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n");

            
            #line 160 "..\..\Views\Blog\EditBlogPost.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
