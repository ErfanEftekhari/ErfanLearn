#pragma checksum "D:\ErfanLearn\ErfanLearn\ErfanLearn\Views\Shared\_DefaultLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "075951bc2aecf45017f03690de23c4d5f1e991f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DefaultLayout), @"mvc.1.0.view", @"/Views/Shared/_DefaultLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_DefaultLayout.cshtml", typeof(AspNetCore.Views_Shared__DefaultLayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"075951bc2aecf45017f03690de23c4d5f1e991f9", @"/Views/Shared/_DefaultLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__DefaultLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_MetaTags", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Styles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_MainMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Footer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 62, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html class=\"no-js\" dir=\"rtl\" lang=\"fa-IR\">\r\n");
            EndContext();
            BeginContext(62, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "075951bc2aecf45017f03690de23c4d5f1e991f94551", async() => {
                BeginContext(68, 54, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <title> عرفان لرن | ");
                EndContext();
                BeginContext(123, 17, false);
#line 5 "D:\ErfanLearn\ErfanLearn\ErfanLearn\Views\Shared\_DefaultLayout.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(140, 15, true);
                WriteLiteral(" </title>\r\n    ");
                EndContext();
                BeginContext(155, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "075951bc2aecf45017f03690de23c4d5f1e991f95354", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(183, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(189, 26, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "075951bc2aecf45017f03690de23c4d5f1e991f96688", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(215, 49, true);
                WriteLiteral("\r\n    <script src=\"/js/jquery.min.js\"></script>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(271, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(273, 2190, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "075951bc2aecf45017f03690de23c4d5f1e991f98871", async() => {
                BeginContext(279, 329, true);
                WriteLiteral(@"
    <script src=""/js/modernizr-custom.js""></script>

    <div class=""landing-layer"">
        <div class=""container"">
            <nav>
                <div class=""row"">
                    <div class=""col-sm-6 col-xs-12"">
                        <ul>
                            <li>
                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 608, "\"", 615, 0);
                EndWriteAttribute();
                BeginContext(616, 57, true);
                WriteLiteral("> همکاری در فروش </a>\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 673, "\"", 680, 0);
                EndWriteAttribute();
                BeginContext(681, 52, true);
                WriteLiteral("> درباره ما </a>\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 733, "\"", 740, 0);
                EndWriteAttribute();
                BeginContext(741, 217, true);
                WriteLiteral("> تماس با ما </a>\r\n                            </li>\r\n                        </ul>\r\n                    </div>\r\n                    <div class=\"col-sm-6 col-xs-12\">\r\n                        <div class=\"clientarea\">\r\n");
                EndContext();
#line 28 "D:\ErfanLearn\ErfanLearn\ErfanLearn\Views\Shared\_DefaultLayout.cshtml"
                             if (User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
                BeginContext(1054, 150, true);
                WriteLiteral("                                  <div class=\"loggein\">\r\n                                      <i class=\"zmdi zmdi-account\"></i><a href=\"/UserPanel\"> ");
                EndContext();
                BeginContext(1205, 18, false);
#line 31 "D:\ErfanLearn\ErfanLearn\ErfanLearn\Views\Shared\_DefaultLayout.cshtml"
                                                                                        Write(User.Identity.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1223, 173, true);
                WriteLiteral(" ، خوش آمدی </a>\r\n                                      /\r\n                                      <a href=\"/Logout\"> خروج </a>\r\n                                      </div>\r\n");
                EndContext();
#line 35 "D:\ErfanLearn\ErfanLearn\ErfanLearn\Views\Shared\_DefaultLayout.cshtml"
                            }
                            else
                            {

#line default
#line hidden
                BeginContext(1492, 312, true);
                WriteLiteral(@"                                  <div class=""signin"">
                                      <i class=""zmdi zmdi-account""></i>
                                      <a href=""/Login""> ورود </a> /
                                      <a href=""/Register""> عضویت </a>
                                  </div> 
");
                EndContext();
#line 43 "D:\ErfanLearn\ErfanLearn\ErfanLearn\Views\Shared\_DefaultLayout.cshtml"
                            }

#line default
#line hidden
                BeginContext(1835, 116, true);
                WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </nav>\r\n            ");
                EndContext();
                BeginContext(1952, 33, false);
#line 48 "D:\ErfanLearn\ErfanLearn\ErfanLearn\Views\Shared\_DefaultLayout.cshtml"
       Write(RenderSection("SearchBox", false));

#line default
#line hidden
                EndContext();
                BeginContext(1985, 60, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <!-- main manu -->\r\n    ");
                EndContext();
                BeginContext(2045, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "075951bc2aecf45017f03690de23c4d5f1e991f913161", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2073, 53, true);
                WriteLiteral("\r\n    <!-- /main manu -->\r\n    <!-- content -->\r\n    ");
                EndContext();
                BeginContext(2127, 12, false);
#line 56 "D:\ErfanLearn\ErfanLearn\ErfanLearn\Views\Shared\_DefaultLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2139, 50, true);
                WriteLiteral("\r\n    <!-- /content -->\r\n    <!-- footer -->\r\n    ");
                EndContext();
                BeginContext(2189, 26, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "075951bc2aecf45017f03690de23c4d5f1e991f914934", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2215, 241, true);
                WriteLiteral("\r\n    <!-- /footer -->\r\n\r\n    <script src=\"/js/bootstrap.min.js\"></script>\r\n    <script src=\"/js/script.js\"></script>\r\n    <script src=\"/js/jquery.validate.min.js\"></script>\r\n    <script src=\"/js/jquery.validate.unobtrusive.js\"></script>\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(2463, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
