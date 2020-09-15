#pragma checksum "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Controllers\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a566f63aa01984975e792e7a309a88693f0185f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Controllers_Profile), @"mvc.1.0.view", @"/Controllers/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Controllers/Profile.cshtml", typeof(AspNetCore.Controllers_Profile))]
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
#line 1 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Controllers\Profile.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a566f63aa01984975e792e7a309a88693f0185f6", @"/Controllers/Profile.cshtml")]
    public class Controllers_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/profile.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ClientJS/EmployeeJS.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Controllers\Profile.cshtml"
  
    ViewData["Title"] = "Profile";
    Layout = "~/Views/Layout/Layout.cshtml";
    var userId = Context.Session.GetString("id");
    var uname = Context.Session.GetString("uname");
    var mail = Context.Session.GetString("email");
    var level = Context.Session.GetString("lvl");
    if (mail == null)
    {
        Context.Response.Redirect("/login");
    }

#line default
#line hidden
#line 14 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Controllers\Profile.cshtml"
 if (level == "Admin")
{

#line default
#line hidden
            BeginContext(440, 213, true);
            WriteLiteral("    <div class=\"container emp-profile\">\r\n        <form method=\"post\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    <div class=\"profile-img\">\r\n                        ");
            EndContext();
            BeginContext(653, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cfee771bf32d4cdda156ff07b0aa6e76", async() => {
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
            BeginContext(687, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(846, 198, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"profile-head\">\r\n                        <h5>\r\n                            ");
            EndContext();
            BeginContext(1045, 24, false);
#line 28 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Controllers\Profile.cshtml"
                       Write(uname.ToUpperInvariant());

#line default
#line hidden
            EndContext();
            BeginContext(1069, 91, true);
            WriteLiteral("\r\n                        </h5>\r\n                        <h6>\r\n                            ");
            EndContext();
            BeginContext(1161, 15, false);
#line 31 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Controllers\Profile.cshtml"
                       Write(level.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(1176, 1095, true);
            WriteLiteral(@"
                        </h6>
                        <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                            <li class=""nav-item"">
                                <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home"" aria-selected=""true"">About</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-4"">
                </div>
                <div class=""col-md-8"">
                    <div class=""tab-content profile-tab"" id=""myTabContent"">
                        <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <label>User Id</label>
                                </div>
                        ");
            WriteLiteral("        <div class=\"col-md-9\">\r\n                                    <p>");
            EndContext();
            BeginContext(2272, 6, false);
#line 52 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Controllers\Profile.cshtml"
                                  Write(userId);

#line default
#line hidden
            EndContext();
            BeginContext(2278, 382, true);
            WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <label>User Name</label>
                                </div>
                                <div class=""col-md-9"">
                                    <p>");
            EndContext();
            BeginContext(2661, 5, false);
#line 60 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Controllers\Profile.cshtml"
                                  Write(uname);

#line default
#line hidden
            EndContext();
            BeginContext(2666, 378, true);
            WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <label>Email</label>
                                </div>
                                <div class=""col-md-9"">
                                    <p>");
            EndContext();
            BeginContext(3045, 4, false);
#line 68 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Controllers\Profile.cshtml"
                                  Write(mail);

#line default
#line hidden
            EndContext();
            BeginContext(3049, 383, true);
            WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <label>Profession</label>
                                </div>
                                <div class=""col-md-9"">
                                    <p>");
            EndContext();
            BeginContext(3433, 5, false);
#line 76 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Controllers\Profile.cshtml"
                                  Write(level);

#line default
#line hidden
            EndContext();
            BeginContext(3438, 342, true);
            WriteLiteral(@"</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </form>
    </div>
    <div class=""card-header py-3"">
        <h6 class=""m-0 font-weight-bold text-primary"">DataTables Example</h6>
    </div>
");
            EndContext();
            BeginContext(3782, 201, true);
            WriteLiteral("    <div class=\"card-body\">\r\n        <div class=\"table-responsive\">\r\n            <table class=\"table table-bordered\" id=\"MydataTable\" width=\"100%\" cellspacing=\"0\"></table>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 94 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Controllers\Profile.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(3995, 213, true);
            WriteLiteral("    <div class=\"container emp-profile\">\r\n        <form method=\"post\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    <div class=\"profile-img\">\r\n                        ");
            EndContext();
            BeginContext(4208, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32accf9a51704163be8079932484e539", async() => {
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
            BeginContext(4242, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4401, 198, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"profile-head\">\r\n                        <h5>\r\n                            ");
            EndContext();
            BeginContext(4600, 24, false);
#line 109 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Controllers\Profile.cshtml"
                       Write(uname.ToUpperInvariant());

#line default
#line hidden
            EndContext();
            BeginContext(4624, 91, true);
            WriteLiteral("\r\n                        </h5>\r\n                        <h6>\r\n                            ");
            EndContext();
            BeginContext(4716, 15, false);
#line 112 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Controllers\Profile.cshtml"
                       Write(level.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(4731, 1095, true);
            WriteLiteral(@"
                        </h6>
                        <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                            <li class=""nav-item"">
                                <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home"" aria-selected=""true"">About</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-4"">
                </div>
                <div class=""col-md-8"">
                    <div class=""tab-content profile-tab"" id=""myTabContent"">
                        <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <label>User Id</label>
                                </div>
                        ");
            WriteLiteral("        <div class=\"col-md-9\">\r\n                                    <p>");
            EndContext();
            BeginContext(5827, 6, false);
#line 133 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Controllers\Profile.cshtml"
                                  Write(userId);

#line default
#line hidden
            EndContext();
            BeginContext(5833, 382, true);
            WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <label>User Name</label>
                                </div>
                                <div class=""col-md-9"">
                                    <p>");
            EndContext();
            BeginContext(6216, 5, false);
#line 141 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Controllers\Profile.cshtml"
                                  Write(uname);

#line default
#line hidden
            EndContext();
            BeginContext(6221, 378, true);
            WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <label>Email</label>
                                </div>
                                <div class=""col-md-9"">
                                    <p>");
            EndContext();
            BeginContext(6600, 4, false);
#line 149 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Controllers\Profile.cshtml"
                                  Write(mail);

#line default
#line hidden
            EndContext();
            BeginContext(6604, 383, true);
            WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <label>Profession</label>
                                </div>
                                <div class=""col-md-9"">
                                    <p>");
            EndContext();
            BeginContext(6988, 5, false);
#line 157 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Controllers\Profile.cshtml"
                                  Write(level);

#line default
#line hidden
            EndContext();
            BeginContext(6993, 215, true);
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </form>\r\n    </div>\r\n");
            EndContext();
#line 166 "D:\FileKerja\MII\ProjectNetCore\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Controllers\Profile.cshtml"
}

#line default
#line hidden
            DefineSection("scriptdbAdmin", async() => {
                BeginContext(7234, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7240, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c50ba2dbebb45d8b6463671dd3a7a48", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7291, 48, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\"></script>\r\n");
                EndContext();
            }
            );
            BeginContext(7342, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
