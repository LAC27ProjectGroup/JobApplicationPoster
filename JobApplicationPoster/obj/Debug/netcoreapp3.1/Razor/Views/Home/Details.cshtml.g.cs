#pragma checksum "C:\Users\elias\OneDrive\MSSA\JobApplicationPoster\JobApplicationPoster\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "450324de9650de8866abc3c0ee47f542070ea71e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\elias\OneDrive\MSSA\JobApplicationPoster\JobApplicationPoster\Views\_ViewImports.cshtml"
using JobApplicationPoster;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elias\OneDrive\MSSA\JobApplicationPoster\JobApplicationPoster\Views\_ViewImports.cshtml"
using JobApplicationPoster.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"450324de9650de8866abc3c0ee47f542070ea71e", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69956246894991a4b4f589d0bbc58eb803bbc4a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JobApplicationPoster.Models.Application>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateApplication", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\elias\OneDrive\MSSA\JobApplicationPoster\JobApplicationPoster\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>\r\n    <h1 style=\"color: cadetblue; text-align: center;\">");
#nullable restore
#line 8 "C:\Users\elias\OneDrive\MSSA\JobApplicationPoster\JobApplicationPoster\Views\Home\Details.cshtml"
                                                 Write(ViewBag.StudentName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n</p>\r\n<div>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 17 "C:\Users\elias\OneDrive\MSSA\JobApplicationPoster\JobApplicationPoster\Views\Home\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Company));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 20 "C:\Users\elias\OneDrive\MSSA\JobApplicationPoster\JobApplicationPoster\Views\Home\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.JobTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "C:\Users\elias\OneDrive\MSSA\JobApplicationPoster\JobApplicationPoster\Views\Home\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\elias\OneDrive\MSSA\JobApplicationPoster\JobApplicationPoster\Views\Home\Details.cshtml"
              var count = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\elias\OneDrive\MSSA\JobApplicationPoster\JobApplicationPoster\Views\Home\Details.cshtml"
             foreach (var item in Model)
             {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\elias\OneDrive\MSSA\JobApplicationPoster\JobApplicationPoster\Views\Home\Details.cshtml"
                 using (Html.BeginForm("DeleteApplication", "Home", new { appId = item.ApplicationId, id = item.StudentId }))
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n");
#nullable restore
#line 36 "C:\Users\elias\OneDrive\MSSA\JobApplicationPoster\JobApplicationPoster\Views\Home\Details.cshtml"
                              count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 39 "C:\Users\elias\OneDrive\MSSA\JobApplicationPoster\JobApplicationPoster\Views\Home\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Company));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 42 "C:\Users\elias\OneDrive\MSSA\JobApplicationPoster\JobApplicationPoster\Views\Home\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.JobTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 45 "C:\Users\elias\OneDrive\MSSA\JobApplicationPoster\JobApplicationPoster\Views\Home\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 48 "C:\Users\elias\OneDrive\MSSA\JobApplicationPoster\JobApplicationPoster\Views\Home\Details.cshtml"
                       Write(Html.ActionLink("Edit", "EditApplication", new { id = item.ApplicationId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                            <input type=\"submit\" value=\"Delete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1700, "\"", 1792, 11);
            WriteAttributeValue("", 1710, "return", 1710, 6, true);
            WriteAttributeValue(" ", 1716, "confirm(\'You", 1717, 13, true);
            WriteAttributeValue(" ", 1729, "are", 1730, 4, true);
            WriteAttributeValue(" ", 1733, "about", 1734, 6, true);
            WriteAttributeValue(" ", 1739, "to", 1740, 3, true);
            WriteAttributeValue(" ", 1742, "delete", 1743, 7, true);
            WriteAttributeValue(" ", 1749, "this", 1750, 5, true);
            WriteAttributeValue(" ", 1754, "application,", 1755, 13, true);
            WriteAttributeValue(" ", 1767, "Company:", 1768, 9, true);
#nullable restore
#line 49 "C:\Users\elias\OneDrive\MSSA\JobApplicationPoster\JobApplicationPoster\Views\Home\Details.cshtml"
WriteAttributeValue(" ", 1776, item.Company, 1777, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1790, "\')", 1790, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 52 "C:\Users\elias\OneDrive\MSSA\JobApplicationPoster\JobApplicationPoster\Views\Home\Details.cshtml"
                 }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\elias\OneDrive\MSSA\JobApplicationPoster\JobApplicationPoster\Views\Home\Details.cshtml"
                  
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<div>\r\n    <p>\r\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "450324de9650de8866abc3c0ee47f542070ea71e9850", async() => {
                WriteLiteral("Add New Application");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\elias\OneDrive\MSSA\JobApplicationPoster\JobApplicationPoster\Views\Home\Details.cshtml"
                                           WriteLiteral(ViewBag.StuId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JobApplicationPoster.Models.Application>> Html { get; private set; }
    }
}
#pragma warning restore 1591
