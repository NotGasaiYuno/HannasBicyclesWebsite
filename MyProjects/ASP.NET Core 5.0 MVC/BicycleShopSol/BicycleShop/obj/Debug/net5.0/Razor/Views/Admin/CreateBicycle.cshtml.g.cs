#pragma checksum "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fe334516911d711b1152c2ef69b3350f61b1d8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CreateBicycle), @"mvc.1.0.view", @"/Views/Admin/CreateBicycle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fe334516911d711b1152c2ef69b3350f61b1d8e", @"/Views/Admin/CreateBicycle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d9b643b71e7ceb182674a1854f50de7d141e073", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CreateBicycle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BicycleModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/MyJS/CreateBicycle.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fe334516911d711b1152c2ef69b3350f61b1d8e4495", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fe334516911d711b1152c2ef69b3350f61b1d8e5461", async() => {
                WriteLiteral("\r\n    <div class=\"d-flex justify-content-between pt-3 pb-3 w-100 rounded shadow-lg\">\r\n        <div class=\"ml-5 w-50\">\r\n            <img id=\"image\" class=\"mb-4 w-100 border rounded w-50\"");
                BeginWriteAttribute("src", " src=", 272, "", 343, 1);
#nullable restore
#line 10 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
WriteAttributeValue("", 277, Model.ImagePath ?? "https://www.ocnk.com/img/icon_fep_itad.png", 277, 66, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 343, "\"", 349, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n        <div class=\"d-flex justify-content-center mr-5 ml-3 w-50\">\r\n");
#nullable restore
#line 13 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
             using (Html.BeginForm("CreateBicycle", "Admin", FormMethod.Post, new { id = "form", novalidate = "" }))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"hidden\" name=\"BicycleId\"");
                BeginWriteAttribute("value", " value=\"", 625, "\"", 649, 1);
#nullable restore
#line 15 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
WriteAttributeValue("", 633, Model.BicycleId, 633, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                <table class=""table text-white"">
                    <tbody>
                        <tr>
                            <th scope=""row"">Image url</th>
                            <td>
                                <input type=""text"" name=""ImagePath"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 946, "\"", 970, 1);
#nullable restore
#line 21 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
WriteAttributeValue("", 954, Model.ImagePath, 954, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" pattern=\"(http(s?):)([/|.|\\w|\\s|-])*\\.(?:jpg|gif|png)\" />\r\n                                ");
#nullable restore
#line 22 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
                           Write(Html.ValidationMessageFor(model => Model.ImagePath));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <div class=""invalid-feedback"">
                                Invalid image url. This field is required. 
                                Value must contain substring "".jpg"" or "".png"".
                            </div>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">Name</th>
                            <td>
                                <input type=""text"" name=""BicycleName"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 1645, "\"", 1671, 1);
#nullable restore
#line 32 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
WriteAttributeValue("", 1653, Model.BicycleName, 1653, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required />\r\n                                ");
#nullable restore
#line 33 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
                           Write(Html.ValidationMessageFor(model => Model.BicycleName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                <div class=""invalid-feedback"">
                                    This field is required.
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">Brand</th>
                            <td>
                                <input type=""text"" name=""Brand"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 2209, "\"", 2229, 1);
#nullable restore
#line 42 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
WriteAttributeValue("", 2217, Model.Brand, 2217, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required />\r\n                                ");
#nullable restore
#line 43 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
                           Write(Html.ValidationMessageFor(model => Model.Brand));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                <div class=""invalid-feedback"">
                                    This field is required.
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">Type</th>
                            <td>
                                <input type=""text"" name=""Type"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 2759, "\"", 2778, 1);
#nullable restore
#line 52 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
WriteAttributeValue("", 2767, Model.Type, 2767, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required />\r\n                                ");
#nullable restore
#line 53 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
                           Write(Html.ValidationMessageFor(model => Model.Type));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                <div class=""invalid-feedback"">
                                    This field is required.
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">Release year</th>
                            <td>
                                <input type=""number"" name=""ReleaseYear"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 3324, "\"", 3350, 1);
#nullable restore
#line 62 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
WriteAttributeValue("", 3332, Model.ReleaseYear, 3332, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"2000\" max=\"2021\" required />\r\n                                ");
#nullable restore
#line 63 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
                           Write(Html.ValidationMessageFor(model => Model.ReleaseYear));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                <div class=""invalid-feedback"">
                                    Invalid release year. This field is required. It must be from 2000 to 2021.
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">Frame material</th>
                            <td>
                                <input type=""text"" name=""FrameMaterial"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 3979, "\"", 4007, 1);
#nullable restore
#line 72 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
WriteAttributeValue("", 3987, Model.FrameMaterial, 3987, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">Wheel size</th>
                            <td>
                                <input type=""text"" name=""WheelSize"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 4292, "\"", 4316, 1);
#nullable restore
#line 78 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
WriteAttributeValue("", 4300, Model.WheelSize, 4300, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" pattern=\"^[1-2]\\d{1}(,5)?$\" required />\r\n                                ");
#nullable restore
#line 79 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
                           Write(Html.ValidationMessageFor(model => Model.WheelSize));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"invalid-feedback\">\r\n                                Invalid wheel size. This field is required. \r\n                                It must be a 10 ");
#nullable restore
#line 82 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
                                            Write("<=");

#line default
#line hidden
#nullable disable
                WriteLiteral(" number ");
#nullable restore
#line 82 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
                                                           Write("<");

#line default
#line hidden
#nullable disable
                WriteLiteral(@" 30 (integer or ..,5).
                            </div>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">Brake type</th>
                            <td>
                                <input type=""text"" name=""BrakeType"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 4991, "\"", 5015, 1);
#nullable restore
#line 89 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
WriteAttributeValue("", 4999, Model.BrakeType, 4999, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">Speed quantity</th>
                            <td>
                                <input type=""number"" name=""SpeedQuantity"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 5310, "\"", 5338, 1);
#nullable restore
#line 95 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
WriteAttributeValue("", 5318, Model.SpeedQuantity, 5318, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" pattern=\"^[1-9]{1}\\d?$\" min=\"1\" max=\"30\" required />\r\n                                ");
#nullable restore
#line 96 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
                           Write(Html.ValidationMessageFor(model => Model.SpeedQuantity));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                <div class=""invalid-feedback"">
                                    Invalid speed quantity. This field is required. It must be from 1 to 30.
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">Maximum weight</th>
                            <td>
                                <input type=""number"" name=""MaxWeight"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 5983, "\"", 6007, 1);
#nullable restore
#line 105 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
WriteAttributeValue("", 5991, Model.MaxWeight, 5991, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"100\" max=\"199\" />\r\n                                ");
#nullable restore
#line 106 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
                           Write(Html.ValidationMessageFor(model => Model.MaxWeight));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                <div class=""invalid-feedback"">
                                    Invalid maximum weight. This field is required. It must be from 100 to 199.
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">Price</th>
                            <td>
                                <input type=""number"" name=""Price"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 6608, "\"", 6628, 1);
#nullable restore
#line 115 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
WriteAttributeValue("", 6616, Model.Price, 6616, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"1000\" pattern=\"^[1-9]\\d+$\" required />\r\n                                ");
#nullable restore
#line 116 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
                           Write(Html.ValidationMessageFor(model => Model.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                <div class=""invalid-feedback"">
                                    Invalid price. This field is required. Its minimum value is 1000.
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">Discount</th>
                            <td>
                                <input type=""number"" name=""Discount"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 7242, "\"", 7265, 1);
#nullable restore
#line 125 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
WriteAttributeValue("", 7250, Model.Discount, 7250, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" pattern=\"(^0$)|(^[1-9]\\d?$)\" required />\r\n                                ");
#nullable restore
#line 126 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
                           Write(Html.ValidationMessageFor(model => Model.Discount));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                <div class=""invalid-feedback"">
                                    Invalid discount. This field is required. Its maximum value is 99.
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">Total</th>
                            <td>
                                <input type=""number"" name=""Total"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 7874, "\"", 7894, 1);
#nullable restore
#line 135 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
WriteAttributeValue("", 7882, Model.Total, 7882, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly />
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">Quantity</th>
                            <td>
                                <input type=""number"" name=""Quantity"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 8187, "\"", 8210, 1);
#nullable restore
#line 141 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
WriteAttributeValue("", 8195, Model.Quantity, 8195, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" pattern=\"(^0$)|(^[1-9]\\d*$)\" required />\r\n                                ");
#nullable restore
#line 142 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
                           Write(Html.ValidationMessageFor(model => Model.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                <div class=""invalid-feedback"">
                                    Invalid quantity. This field is required.
                                </div>
                            </td>
                        </tr>
                    </tbody>
                </table>
                <input type=""submit"" value=""Finish"" class=""btn btn-dark border border-white w-100"" />
");
#nullable restore
#line 151 "C:\Users\1\Documents\BicycleShopSol\BicycleShop\Views\Admin\CreateBicycle.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fe334516911d711b1152c2ef69b3350f61b1d8e23953", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BicycleModel> Html { get; private set; }
    }
}
#pragma warning restore 1591