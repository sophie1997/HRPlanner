#pragma checksum "C:\Users\chopkinson\source\repos\HRPlanner\HRPlanner\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ca9f4051013d508bae2a4388afb47d79ee68fad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#line 1 "C:\Users\chopkinson\source\repos\HRPlanner\HRPlanner\Views\_ViewImports.cshtml"
using HRPlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chopkinson\source\repos\HRPlanner\HRPlanner\Views\_ViewImports.cshtml"
using HRPlanner.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ca9f4051013d508bae2a4388afb47d79ee68fad", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7b00aad92cad7e9cb8ef362e90c8921ec7d338d", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\chopkinson\source\repos\HRPlanner\HRPlanner\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Users</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-4\">\r\n        Name\r\n    </div>\r\n    <div class=\"col-1\">\r\n        Edit\r\n    </div>\r\n    <div class=\"col-1\">\r\n        Remove\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 18 "C:\Users\chopkinson\source\repos\HRPlanner\HRPlanner\Views\Users\Index.cshtml"
 foreach (var user in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-4\">\r\n        <p>");
#nullable restore
#line 22 "C:\Users\chopkinson\source\repos\HRPlanner\HRPlanner\Views\Users\Index.cshtml"
      Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "C:\Users\chopkinson\source\repos\HRPlanner\HRPlanner\Views\Users\Index.cshtml"
                      Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"col-1\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 436, "\"", 467, 2);
            WriteAttributeValue("", 443, "/Users/Edit/", 443, 12, true);
#nullable restore
#line 25 "C:\Users\chopkinson\source\repos\HRPlanner\HRPlanner\Views\Users\Index.cshtml"
WriteAttributeValue("", 455, user.UserId, 455, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-sm fa-user-edit\"></i></a>\r\n    </div>\r\n    <div class=\"col-1\">\r\n        <a href=\"#\"><i class=\"fa fa-sm fa-user-times\"></i></a>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 31 "C:\Users\chopkinson\source\repos\HRPlanner\HRPlanner\Views\Users\Index.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
