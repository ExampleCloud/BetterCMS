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
    
    #line 1 "..\..\Views\Shared\Partial\WarnMessageAboutDraft.cshtml"
    using BetterCms.Core.DataContracts.Enums;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\Partial\WarnMessageAboutDraft.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Shared\Partial\WarnMessageAboutDraft.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Partial/WarnMessageAboutDraft.cshtml")]
    public partial class _Views_Shared_Partial_WarnMessageAboutDraft_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Content.IDraftDestroy>
    {
        public _Views_Shared_Partial_WarnMessageAboutDraft_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 7 "..\..\Views\Shared\Partial\WarnMessageAboutDraft.cshtml"
 if (Model.CurrentStatus == ContentStatus.Draft)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"bcms-messages-ui bcms-js-messages\"");

WriteLiteral(">\r\n        <ul");

WriteLiteral(" class=\"bcms-success-messages\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral("></ul>\r\n        <ul");

WriteLiteral(" class=\"bcms-info-messages\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral("></ul>\r\n        <ul");

WriteLiteral(" class=\"bcms-warning-messages\"");

WriteLiteral(">\r\n            <li>\r\n                <a");

WriteLiteral(" class=\"bcms-messages-close bcms-js-btn-close\"");

WriteLiteral(" id=\"bcms-draft-closeinfomessage\"");

WriteLiteral(">");

            
            #line 14 "..\..\Views\Shared\Partial\WarnMessageAboutDraft.cshtml"
                                                                                             Write(RootGlobalization.Button_Close);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

WriteLiteral("                ");

            
            #line 15 "..\..\Views\Shared\Partial\WarnMessageAboutDraft.cshtml"
           Write(PagesGlobalization.EditPageContent_Messages_DraftStatusWarnMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 16 "..\..\Views\Shared\Partial\WarnMessageAboutDraft.cshtml"
                
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Shared\Partial\WarnMessageAboutDraft.cshtml"
                 if (Model.CanDestroyDraft)
                {
                    
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Shared\Partial\WarnMessageAboutDraft.cshtml"
               Write(Html.Raw(PagesGlobalization.EditPageContent_Messages_DraftStatusWarnMessage_Destroy));

            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Shared\Partial\WarnMessageAboutDraft.cshtml"
                                                                                                         
                }

            
            #line default
            #line hidden
WriteLiteral("            </li>\r\n        </ul>\r\n        <ul");

WriteLiteral(" class=\"bcms-error-messages\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral("></ul>\r\n    </div>\r\n");

            
            #line 24 "..\..\Views\Shared\Partial\WarnMessageAboutDraft.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
