#pragma checksum "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Shopping\Buy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cef40f8c94d7fd5c945283304e7b3771af07e55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shopping_Buy), @"mvc.1.0.view", @"/Views/Shopping/Buy.cshtml")]
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
#line 1 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\_ViewImports.cshtml"
using BicycleShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\_ViewImports.cshtml"
using BicycleShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cef40f8c94d7fd5c945283304e7b3771af07e55", @"/Views/Shopping/Buy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d9b643b71e7ceb182674a1854f50de7d141e073", @"/Views/_ViewImports.cshtml")]
    public class Views_Shopping_Buy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cef40f8c94d7fd5c945283304e7b3771af07e553575", async() => {
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cef40f8c94d7fd5c945283304e7b3771af07e554541", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Shopping\Buy.cshtml"
     if (ViewBag.Success != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div id=\"my-alert\" class=\"alert alert-danger alert-dismissible fade show\" role=\"alert\">\r\n            <h4 class=\"alert-heading\">");
#nullable restore
#line 9 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Shopping\Buy.cshtml"
                                 Write(ViewBag.Success);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h4>
            <hr>
            <p class=""mb-0"">Make shure the entered e-mail is correct.</p>
            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
            </button>
        </div>
");
#nullable restore
#line 16 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Shopping\Buy.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"d-flex justify-content-center pt-3 pb-3 w-100 rounded shadow-lg\">\r\n    <div>\r\n        <img class=\"mb-4 w-100\" src=\"https://akhawat.islamway.net/forum/uploads/monthly_07_2011/post-362660-1310320744_thumb.png\"");
                BeginWriteAttribute("alt", " alt=\"", 771, "\"", 777, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </div>\r\n    <div class=\"d-flex justify-content-center col-7 mt-5 mr-5\">\r\n");
#nullable restore
#line 22 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Shopping\Buy.cshtml"
         using (Html.BeginForm("Buy", "Shopping", FormMethod.Post, new { @class = "w-75", id = "form", novalidate = "" }))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>\r\n                <label class=\"form-label text-white\" for=\"name\">Name</label>\r\n                <input type=\"text\" id=\"name\" name=\"Name\" class=\"form-control\" placeholder=\"John\"");
                BeginWriteAttribute("value", " value=\"", 1188, "\"", 1196, 0);
                EndWriteAttribute();
                WriteLiteral(" required pattern=\"(^[A-Z]{1}[a-z]* {1})*[A-Z]{1}[a-z]*$\" />\r\n                <div class=\"invalid-feedback\">\r\n                    This field is required. Make shure the entered name consists of letters only.\r\n                </div>\r\n            </div>\r\n");
                WriteLiteral("            <div>\r\n                <label class=\"form-label text-white\" for=\"lastname\">Last Name</label>\r\n                <input type=\"text\" id=\"lastname\" name=\"Lastname\" class=\"form-control\" placeholder=\"Smith\"");
                BeginWriteAttribute("value", " value=\"", 1663, "\"", 1671, 0);
                EndWriteAttribute();
                WriteLiteral(" required pattern=\"^[A-Z]{1}[a-z]*$\" />\r\n                <div class=\"invalid-feedback\">\r\n                    This field is required. Make shure the entered last name consists of letters only.\r\n                </div>\r\n            </div>\r\n");
                WriteLiteral("            <div>\r\n                <label class=\"form-label text-white\" for=\"email\">E-mail adress</label>\r\n                <input type=\"text\" id=\"email\" name=\"Email\" class=\"form-control\" placeholder=\"my_email@gmail.com\"");
                BeginWriteAttribute("value", " value=\"", 2130, "\"", 2157, 1);
#nullable restore
#line 42 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Shopping\Buy.cshtml"
WriteAttributeValue("", 2138, User.Identity.Name, 2138, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("pattern", " pattern=\"", 2158, "\"", 2215, 3);
                WriteAttributeValue("", 2168, "[a-zA-Z0-9._%+-]+", 2168, 17, true);
#nullable restore
#line 42 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Shopping\Buy.cshtml"
WriteAttributeValue("", 2185, "@", 2185, 6, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2191, "[a-z0-9.-]+\\.[a-z]{2,3}$", 2191, 24, true);
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n            </div>\r\n            <div class=\"mt-5\">\r\n                <button class=\"btn btn-dark border-white w-50\" type=\"submit\">Buy</button>\r\n            </div>\r\n");
#nullable restore
#line 47 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Shopping\Buy.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591