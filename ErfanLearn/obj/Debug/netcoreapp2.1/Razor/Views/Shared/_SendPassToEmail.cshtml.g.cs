#pragma checksum "D:\ErfanLearn\ErfanLearn\ErfanLearn\Views\Shared\_SendPassToEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "077139fb20806a4c027e86ce7d33377833d04f10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SendPassToEmail), @"mvc.1.0.view", @"/Views/Shared/_SendPassToEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_SendPassToEmail.cshtml", typeof(AspNetCore.Views_Shared__SendPassToEmail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"077139fb20806a4c027e86ce7d33377833d04f10", @"/Views/Shared/_SendPassToEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SendPassToEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErfanLearn.DataLayer.Entities.User.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 55, true);
            WriteLiteral("\r\n<div style=\"direction: rtl; padding: 20px\">\r\n    <h2>");
            EndContext();
            BeginContext(104, 14, false);
#line 4 "D:\ErfanLearn\ErfanLearn\ErfanLearn\Views\Shared\_SendPassToEmail.cshtml"
   Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(118, 111, true);
            WriteLiteral(" عزیز !</h2>\r\n    <p>\r\n       جهت بازیابی حساب کاربری خود روی لینک زیر کلیک کنید\r\n    </p>\r\n    <p>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 229, "\"", 299, 2);
            WriteAttributeValue("", 236, "https://localhost:44367/Account/ResetPassword/", 236, 46, true);
#line 9 "D:\ErfanLearn\ErfanLearn\ErfanLearn\Views\Shared\_SendPassToEmail.cshtml"
WriteAttributeValue("", 282, Model.ActiveCode, 282, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(300, 42, true);
            WriteLiteral(">بازیابی کلمه عبور</a>\r\n    </p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErfanLearn.DataLayer.Entities.User.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
