#pragma checksum "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\Division\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "034a355408b42fd4ba84b31034384dcf061bf66f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Division_Index), @"mvc.1.0.view", @"/Views/Division/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Division/Index.cshtml", typeof(AspNetCore.Views_Division_Index))]
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
#line 1 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\_ViewImports.cshtml"
using Client;

#line default
#line hidden
#line 2 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\_ViewImports.cshtml"
using Client.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"034a355408b42fd4ba84b31034384dcf061bf66f", @"/Views/Division/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_Division_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ClientJS/DivisionJS.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\Division\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Layout/Layout.cshtml";

#line default
#line hidden
            BeginContext(87, 86, true);
            WriteLiteral("<!-- Start Page Content -->\r\n<!-- Page Heading -->\r\n<h1 class=\"h3 mb-2 text-gray-800\">");
            EndContext();
            BeginContext(174, 13, false);
#line 7 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\Division\Index.cshtml"
                             Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(187, 248, true);
            WriteLiteral("</h1>\r\n\r\n<!-- DataTales Example -->\r\n<div class=\"card shadow mb-4\">\r\n    <div class=\"card-header py-3\">\r\n        <div class=\"d-flex flex-row align-content-between justify-content-between\">\r\n            <h5 class=\"m-0 font-weight-bold text-primary\">");
            EndContext();
            BeginContext(436, 13, false);
#line 13 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\Division\Index.cshtml"
                                                     Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(449, 1075, true);
            WriteLiteral(@" Table</h5>
            <div data-toggle=""modal"" data-target=""#myModal"" onclick=""ClearScreen();"">
                <button class=""btn btn-outline-success btn-circle"" data-toggle=""tooltip"" data-placement=""top"" data-animation=""false"" title=""Add"">
                    <i class=""fa fa-plus""></i>
                </button>
            </div>
        </div>
    </div>
    <div class=""card-body"">
        <!-- Modal -->
        <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header no-bd"">
                        <h5 class=""modal-title""><span class=""fw-mediumbold"">Form Data</span></h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                   ");
            WriteLiteral(" <div class=\"modal-body\">\r\n                        ");
            EndContext();
            BeginContext(1524, 1037, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89428c29894e4bed9abd51c2464ffe05", async() => {
                BeginContext(1530, 1024, true);
                WriteLiteral(@"
                            <div class=""row"">
                                <input type=""text"" id=""Id"" name=""Id"" class=""form-control"" hidden>
                                <div class=""col-sm-12"">
                                    <div class=""form-group form-group-default"">
                                        <label>Name</label>
                                        <input type=""text"" id=""Name"" name=""Name"" class=""form-control"" placeholder=""fill name"">
                                    </div>
                                </div>
                                <div class=""col-sm-12"">
                                    <div class=""form-group form-group-default"">
                                        <label>Division</label>
                                        <select class=""form-control"" id=""DepartOption"" name=""DepartOption""></select>
                                    </div>
                                </div>
                            </div>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2561, 1198, true);
            WriteLiteral(@"
                    </div>
                    <div class=""modal-footer no-bd"">
                        <button type=""button"" id=""add"" class=""btn btn-outline-success"" data-dismiss=""modal"" onclick=""Save();"">Insert</button>
                        <button type=""button"" id=""update"" class=""btn btn-outline-warning"" data-dismiss=""modal"" onclick=""Update();"">Update</button>
                        <button type=""button"" class=""btn btn-outline-danger"" data-dismiss=""modal"">Close</button>
                    </div>
                </div>
            </div>
        </div>
        <!-- End Modal -->
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""division"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>No</th>
                        <th>Division Name</th>
                        <th>Departement Name</th>
                        <th>Create Date</th>
                        <th>Update Date</th>
       ");
            WriteLiteral("                 <th>Action</th>\r\n                    </tr>\r\n                </thead>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- End PAge Content -->\r\n\r\n");
            EndContext();
            DefineSection("scriptdbAdmin", async() => {
                BeginContext(3782, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3788, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b98658d11f4148ccbe5c15f65f65b066", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3839, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
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
