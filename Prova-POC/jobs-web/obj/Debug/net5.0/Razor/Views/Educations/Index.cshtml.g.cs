#pragma checksum "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c07e0a1b62087b0e66b0d069d500d83b371d54f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Educations_Index), @"mvc.1.0.view", @"/Views/Educations/Index.cshtml")]
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
#line 1 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\_ViewImports.cshtml"
using Jobs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\_ViewImports.cshtml"
using Jobs.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c07e0a1b62087b0e66b0d069d500d83b371d54f7", @"/Views/Educations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38d09b94bec750800d2f3804557b477055f15fcb", @"/Views/_ViewImports.cshtml")]
    public class Views_Educations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Jobs.Models.Education>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style-IndexTable.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c07e0a1b62087b0e66b0d069d500d83b371d54f76550", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c07e0a1b62087b0e66b0d069d500d83b371d54f76812", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link href=\"https://fonts.googleapis.com/css2?family=Inter:wght@200;500;800&display=swap\" rel=\"stylesheet\">\r\n    <title>Tabela Formação</title>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c07e0a1b62087b0e66b0d069d500d83b371d54f78943", async() => {
                WriteLiteral("\r\n\r\n\r\n    <h1>Controle das formações acadêmicas</h1>\r\n    <p>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c07e0a1b62087b0e66b0d069d500d83b371d54f79278", async() => {
                    WriteLiteral("Cadastrar Formação Acadêmica");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </p>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Institution));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 26 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Course));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 29 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CourseType));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 32 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 35 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 38 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CandidateId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 44 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml"
 if (item.Candidate.UserId == Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier)))
{

#line default
#line hidden
#nullable disable
                WriteLiteral("<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 50 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Institution));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 53 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Course));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 56 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.CourseType));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 59 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 62 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 65 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.CandidateId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c07e0a1b62087b0e66b0d069d500d83b371d54f715943", async() => {
                    WriteLiteral("Editar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml"
                               WriteLiteral(item.Id);

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
                WriteLiteral(" |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c07e0a1b62087b0e66b0d069d500d83b371d54f718258", async() => {
                    WriteLiteral("Detalhes");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml"
                                  WriteLiteral(item.Id);

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
                WriteLiteral(" |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c07e0a1b62087b0e66b0d069d500d83b371d54f720578", async() => {
                    WriteLiteral("Excluir");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml"
                                 WriteLiteral(item.Id);

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
                WriteLiteral("\r\n    </td>\r\n</tr>\r\n");
#nullable restore
#line 73 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\isaca\source\repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos\Prova-POC\jobs-web\Views\Educations\Index.cshtml"
 }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Jobs.Models.Education>> Html { get; private set; }
    }
}
#pragma warning restore 1591
