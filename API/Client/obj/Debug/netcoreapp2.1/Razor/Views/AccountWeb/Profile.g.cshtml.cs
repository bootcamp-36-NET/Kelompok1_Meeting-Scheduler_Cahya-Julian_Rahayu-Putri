#pragma checksum "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f29c1ba20ffb7ca88b870450c1f3d1626e7121ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountWeb_Profile), @"mvc.1.0.view", @"/Views/AccountWeb/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AccountWeb/Profile.cshtml", typeof(AspNetCore.Views_AccountWeb_Profile))]
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
#line 1 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\_ViewImports.cshtml"
using Client;

#line default
#line hidden
#line 2 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\_ViewImports.cshtml"
using Client.Models;

#line default
#line hidden
#line 1 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f29c1ba20ffb7ca88b870450c1f3d1626e7121ff", @"/Views/AccountWeb/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountWeb_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/profile.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
  
    ViewData["Title"] = "Profile";
    Layout = "~/Views/Layout/Layout.cshtml";
    var userId = Context.Session.GetString("id");
    var gender = Context.Session.GetString("gender");
    var phone = Context.Session.GetString("phone");
    var address = Context.Session.GetString("address");
    var uname = Context.Session.GetString("uname");
    var mail = Context.Session.GetString("email");
    var fullName = Context.Session.GetString("fullName");
    var level = Context.Session.GetString("lvl");

    if (mail == null)
    {
        Context.Response.Redirect("/login");
    }

#line default
#line hidden
#line 19 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
 if (level == "Admin")
{

#line default
#line hidden
            BeginContext(666, 49, true);
            WriteLiteral("    <div class=\"container emp-profile\">\r\n        ");
            EndContext();
            BeginContext(715, 4543, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c7eaa92e05545ecb9327c7ae7976a8a", async() => {
                BeginContext(735, 144, true);
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    <div class=\"profile-img\">\r\n                        ");
                EndContext();
                BeginContext(879, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2059382379e14453be34f0ca4b7b59ca", async() => {
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
                BeginContext(913, 200, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"profile-head\">\r\n                        <h5>\r\n                            ");
                EndContext();
                BeginContext(1114, 18, false);
#line 32 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
                       Write(fullName.ToUpper());

#line default
#line hidden
                EndContext();
                BeginContext(1132, 91, true);
                WriteLiteral("\r\n                        </h5>\r\n                        <h6>\r\n                            ");
                EndContext();
                BeginContext(1224, 15, false);
#line 35 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
                       Write(level.ToUpper());

#line default
#line hidden
                EndContext();
                BeginContext(1239, 1095, true);
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
                BeginContext(2335, 6, false);
#line 56 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
                                  Write(userId);

#line default
#line hidden
                EndContext();
                BeginContext(2341, 382, true);
                WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <label>Full Name</label>
                                </div>
                                <div class=""col-md-9"">
                                    <p>");
                EndContext();
                BeginContext(2724, 8, false);
#line 64 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
                                  Write(fullName);

#line default
#line hidden
                EndContext();
                BeginContext(2732, 379, true);
                WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <label>Gender</label>
                                </div>
                                <div class=""col-md-9"">
                                    <p>");
                EndContext();
                BeginContext(3112, 6, false);
#line 72 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
                                  Write(gender);

#line default
#line hidden
                EndContext();
                BeginContext(3118, 385, true);
                WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <label>Phone Number</label>
                                </div>
                                <div class=""col-md-9"">
                                    <p>");
                EndContext();
                BeginContext(3504, 5, false);
#line 80 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
                                  Write(phone);

#line default
#line hidden
                EndContext();
                BeginContext(3509, 382, true);
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
                BeginContext(3892, 5, false);
#line 88 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
                                  Write(uname);

#line default
#line hidden
                EndContext();
                BeginContext(3897, 378, true);
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
                BeginContext(4276, 4, false);
#line 96 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
                                  Write(mail);

#line default
#line hidden
                EndContext();
                BeginContext(4280, 383, true);
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
                BeginContext(4664, 5, false);
#line 104 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
                                  Write(level);

#line default
#line hidden
                EndContext();
                BeginContext(4669, 380, true);
                WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <label>Address</label>
                                </div>
                                <div class=""col-md-9"">
                                    <p>");
                EndContext();
                BeginContext(5050, 7, false);
#line 112 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
                                  Write(address);

#line default
#line hidden
                EndContext();
                BeginContext(5057, 194, true);
                WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5258, 141, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"card-header py-3\">\r\n        <h6 class=\"m-0 font-weight-bold text-primary\">DataTables Example</h6>\r\n    </div>\r\n");
            EndContext();
            BeginContext(5401, 201, true);
            WriteLiteral("    <div class=\"card-body\">\r\n        <div class=\"table-responsive\">\r\n            <table class=\"table table-bordered\" id=\"MydataTable\" width=\"100%\" cellspacing=\"0\"></table>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 130 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(5614, 49, true);
            WriteLiteral("    <div class=\"container emp-profile\">\r\n        ");
            EndContext();
            BeginContext(5663, 4544, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b872a88957214f809615b0d16916aea0", async() => {
                BeginContext(5683, 144, true);
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    <div class=\"profile-img\">\r\n                        ");
                EndContext();
                BeginContext(5827, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e7a0f36546dd4af79f45760c3fc2f7c0", async() => {
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
                BeginContext(5861, 200, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"profile-head\">\r\n                        <h5>\r\n                            ");
                EndContext();
                BeginContext(6062, 27, false);
#line 144 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
                       Write(fullName.ToUpperInvariant());

#line default
#line hidden
                EndContext();
                BeginContext(6089, 93, true);
                WriteLiteral("\r\n\r\n                        </h5>\r\n                        <h6>\r\n                            ");
                EndContext();
                BeginContext(6183, 5, false);
#line 148 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
                       Write(level);

#line default
#line hidden
                EndContext();
                BeginContext(6188, 1095, true);
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
                BeginContext(7284, 6, false);
#line 169 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
                                  Write(userId);

#line default
#line hidden
                EndContext();
                BeginContext(7290, 382, true);
                WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <label>Full Name</label>
                                </div>
                                <div class=""col-md-9"">
                                    <p>");
                EndContext();
                BeginContext(7673, 8, false);
#line 177 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
                                  Write(fullName);

#line default
#line hidden
                EndContext();
                BeginContext(7681, 379, true);
                WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <label>Gender</label>
                                </div>
                                <div class=""col-md-9"">
                                    <p>");
                EndContext();
                BeginContext(8061, 6, false);
#line 185 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
                                  Write(gender);

#line default
#line hidden
                EndContext();
                BeginContext(8067, 385, true);
                WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <label>Phone Number</label>
                                </div>
                                <div class=""col-md-9"">
                                    <p>");
                EndContext();
                BeginContext(8453, 5, false);
#line 193 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
                                  Write(phone);

#line default
#line hidden
                EndContext();
                BeginContext(8458, 382, true);
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
                BeginContext(8841, 5, false);
#line 201 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
                                  Write(uname);

#line default
#line hidden
                EndContext();
                BeginContext(8846, 378, true);
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
                BeginContext(9225, 4, false);
#line 209 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
                                  Write(mail);

#line default
#line hidden
                EndContext();
                BeginContext(9229, 383, true);
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
                BeginContext(9613, 5, false);
#line 217 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
                                  Write(level);

#line default
#line hidden
                EndContext();
                BeginContext(9618, 380, true);
                WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <label>Address</label>
                                </div>
                                <div class=""col-md-9"">
                                    <p>");
                EndContext();
                BeginContext(9999, 7, false);
#line 225 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
                                  Write(address);

#line default
#line hidden
                EndContext();
                BeginContext(10006, 194, true);
                WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10207, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 234 "D:\MII-BC36-Git\Entahlaaah\Kelompok1_Meeting-Scheduler_Cahya-Julian_Rahayu-Putri\API\Client\Views\AccountWeb\Profile.cshtml"
}

#line default
#line hidden
            DefineSection("scriptdbAdmin", async() => {
                BeginContext(10247, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(10310, 46, true);
                WriteLiteral("    <script type=\"text/javascript\"></script>\r\n");
                EndContext();
            }
            );
            BeginContext(10359, 2, true);
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