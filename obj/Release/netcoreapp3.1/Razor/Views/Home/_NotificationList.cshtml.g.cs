#pragma checksum "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Home\_NotificationList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2593c5a00f93e4854ff445178b6c6b6cf96efeda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__NotificationList), @"mvc.1.0.view", @"/Views/Home/_NotificationList.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\_ViewImports.cshtml"
using SCASA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\_ViewImports.cshtml"
using SCASA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2593c5a00f93e4854ff445178b6c6b6cf96efeda", @"/Views/Home/_NotificationList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f59c02fdbf6895e021479e28253e13dd514c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__NotificationList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SCASA.Models.Repositories.Entity.ActivityLog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<li class=""nav-item dropdown notifications-menu"">
    <a class=""nav-link admin-notification"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
        <i class=""pe-7s-bell""></i>
        <span class=""label bg-warning"">");
#nullable restore
#line 6 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Home\_NotificationList.cshtml"
                                  Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </a>\r\n    <div class=\"dropdown-menu drop_drops custom_drop_scroll\">\r\n");
#nullable restore
#line 9 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Home\_NotificationList.cshtml"
         foreach (var v in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"dropdown-item\" href=\"#\">\r\n                <div class=\"menues\">\r\n                    <p>\r\n                        <i class=\"fa fa-dot-circle-o color-red\"></i>\r\n                        ");
#nullable restore
#line 15 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Home\_NotificationList.cshtml"
                   Write(v.ActivityText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </a>\r\n");
#nullable restore
#line 19 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Home\_NotificationList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n    </li>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SCASA.Models.Repositories.Entity.ActivityLog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
