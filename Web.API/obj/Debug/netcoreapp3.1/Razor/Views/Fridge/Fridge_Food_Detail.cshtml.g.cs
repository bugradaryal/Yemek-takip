#pragma checksum "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e004a4352b9a490421366c0e0460f39371ae549"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fridge_Fridge_Food_Detail), @"mvc.1.0.view", @"/Views/Fridge/Fridge_Food_Detail.cshtml")]
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
#line 1 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\_ViewImports.cshtml"
using Web.API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\_ViewImports.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\_ViewImports.cshtml"
using Web.API.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e004a4352b9a490421366c0e0460f39371ae549", @"/Views/Fridge/Fridge_Food_Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da4c3a96886fc603bf249a561af2b371cc0bb1a9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Fridge_Fridge_Food_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModels>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/fridge_food_detail.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Fridge", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Fridge", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
  
    ViewData["Title"] = ViewBag.CurrentView;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e004a4352b9a490421366c0e0460f39371ae5496353", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8e004a4352b9a490421366c0e0460f39371ae5496615", async() => {
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<div class=\"bodydiv\">\r\n     <div class=\"content\">\r\n                <div>\r\n");
#nullable restore
#line 15 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
                     foreach(var x in Model.Food)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <b class=\"başlık\">");
#nullable restore
#line 17 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
                                         Write(x.yemek_ismi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b>
                                <table> 
                                <tr>
                                <th>Protein(%)</th> 
                                <th>Protein(gr)</th> 
                                <th>Yağ(%)</th> 
                                <th>Yağ(gr)</th>
                                <th>Karbonhidrat(%)</th>
                                <th>Karbonhidrat(gr)</th>
                                <th>Kalori</th>
                                <th>Sodyum(gr)</th>
                                <th>Potasyum(gr)</th>
                                <th>Kalsiyum(gr)</th>
                                <th>Lif(gr)</th>
                                <th>Kollestrol(gr)</th>
                                <th>Bozulma Süresi</th>

                                </tr>
                                    <tr> 
                                    <td>");
#nullable restore
#line 36 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
                                   Write(x.protein_yüzde);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                                    <td>");
#nullable restore
#line 37 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
                                   Write(x.protein_gr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                                    <td>");
#nullable restore
#line 38 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
                                   Write(x.yağ_yüzde);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                                    <td>");
#nullable restore
#line 39 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
                                   Write(x.yağ_gr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                                    <td>");
#nullable restore
#line 40 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
                                   Write(x.karbonhidrat_yüzde);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                                    <td>");
#nullable restore
#line 41 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
                                   Write(x.karbonhidrat_gr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                                    <td>");
#nullable restore
#line 42 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
                                   Write(x.kalori);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                                    <td>");
#nullable restore
#line 43 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
                                   Write(x.sodyum_gr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                                    <td>");
#nullable restore
#line 44 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
                                   Write(x.potasyum_gr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 45 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
                                   Write(x.kalsiyum_gr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                                    <td>");
#nullable restore
#line 46 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
                                   Write(x.lif_gr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                                    <td>");
#nullable restore
#line 47 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
                                   Write(x.kollestrol_gr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                                    <td>");
#nullable restore
#line 48 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
                                   Write(x.gün_bozulma_tarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n\r\n                                </tr> \r\n                                </table> \r\n");
#nullable restore
#line 52 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div>\r\n                     <b style=\"margin-left:2vw\">");
#nullable restore
#line 55 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
                                           Write(ViewBag.error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                </div>\r\n                <div class=\"flexbutton\">\r\n                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e004a4352b9a490421366c0e0460f39371ae54914730", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8e004a4352b9a490421366c0e0460f39371ae54915009", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 59 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.User.id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
                                                    WriteLiteral(Model.User.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8e004a4352b9a490421366c0e0460f39371ae54917435", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 60 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Fridge_id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\bugra\Desktop\Yemek_Takip\Web.API\Views\Fridge\Fridge_Food_Detail.cshtml"
                                                      WriteLiteral(Model.Fridge_id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                     <button type=\"submit\" id=\"işlem_buton\" class=\"btn btn-secondary\">Buzdolabım</button>  \r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n</div>\r\n\r\n        ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModels> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
