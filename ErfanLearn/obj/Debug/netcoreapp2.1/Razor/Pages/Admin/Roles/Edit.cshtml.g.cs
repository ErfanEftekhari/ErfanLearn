#pragma checksum "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "403ccdf0941c16a7587fe11298839b84ee795b3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Roles_Edit), @"mvc.1.0.razor-page", @"/Pages/Admin/Roles/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Roles/Edit.cshtml", typeof(AspNetCore.Pages_Admin_Roles_Edit), @"{id}")]
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
#line 2 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
using ErfanLearn.DataLayer.Entities.User;

#line default
#line hidden
#line 3 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
using ErfanLearn.DataLayer.Entities.Permission;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"403ccdf0941c16a7587fe11298839b84ee795b3c", @"/Pages/Admin/Roles/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Roles_Edit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
  
    ViewData["Title"] = "ویرایش نقش";
    List<Permission> permissions = ViewData["Permissions"] as List<Permission>;

#line default
#line hidden
            BeginContext(284, 170, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <h1 class=\"page-header\">ویرایش نقش</h1>\r\n    </div>\r\n    <!-- /.col-lg-12 -->\r\n</div>\r\n\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(454, 4275, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "403ccdf0941c16a7587fe11298839b84ee795b3c5848", async() => {
                BeginContext(504, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(514, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "403ccdf0941c16a7587fe11298839b84ee795b3c6238", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 19 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.RoleId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(558, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(568, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "403ccdf0941c16a7587fe11298839b84ee795b3c8049", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 20 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.RoleTitle);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(615, 413, true);
                WriteLiteral(@"
        <div class=""col-md-8"">
            <div class=""panel panel-primary"">
                <div class=""panel-heading"">
                    اطلاعات نقش
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
                    <div class=""form-group"">
                        <label>نام نقش</label>
                        <label class=""text-success"">");
                EndContext();
                BeginContext(1029, 20, false);
#line 30 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
                                               Write(Model.Role.RoleTitle);

#line default
#line hidden
                EndContext();
                BeginContext(1049, 38, true);
                WriteLiteral("</label>\r\n                    </div>\r\n");
                EndContext();
                BeginContext(1690, 120, true);
                WriteLiteral("                    <div class=\"form-group\">\r\n                        <label>وضعیت نقش</label>\r\n                        ");
                EndContext();
                BeginContext(1810, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "403ccdf0941c16a7587fe11298839b84ee795b3c10933", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 45 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IsActive);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1853, 161, true);
                WriteLiteral("\r\n                    </div>\r\n                    <input type=\"submit\" value=\"ویرایش اطلاعات\" class=\"btn btn-success\"/>\r\n                </div>\r\n                ");
                EndContext();
                BeginContext(2014, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "403ccdf0941c16a7587fe11298839b84ee795b3c12908", async() => {
                    BeginContext(2068, 20, true);
                    WriteLiteral("\r\n\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 49 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2094, 199, true);
                WriteLiteral(" \r\n                <!-- /.panel-body -->\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <div class=\"panel panel-default\">\r\n                <div class=\"panel-body\">\r\n");
                EndContext();
#line 58 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
                      
                        List<int> SelectedPermissions = ViewData["SelectedPermissions"] as List<int>;
                    

#line default
#line hidden
                BeginContext(2443, 26, true);
                WriteLiteral("                    <ul>\r\n");
                EndContext();
#line 62 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
                         foreach (var permission in permissions.Where(p => p.ParentId == null))
                        {

#line default
#line hidden
                BeginContext(2593, 115, true);
                WriteLiteral("                            <li>\r\n                                <input type=\"checkbox\" name=\"SelectedPermission\" ");
                EndContext();
                BeginContext(2710, 69, false);
#line 65 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
                                                                             Write((SelectedPermissions.Any(p=>p==permission.PermissionId)?"checked":""));

#line default
#line hidden
                EndContext();
                BeginContext(2780, 8, true);
                WriteLiteral(" value=\"");
                EndContext();
                BeginContext(2789, 23, false);
#line 65 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
                                                                                                                                                            Write(permission.PermissionId);

#line default
#line hidden
                EndContext();
                BeginContext(2812, 4, true);
                WriteLiteral("\"/> ");
                EndContext();
                BeginContext(2817, 26, false);
#line 65 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
                                                                                                                                                                                        Write(permission.PermissionTitle);

#line default
#line hidden
                EndContext();
                BeginContext(2843, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 67 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
                                 if (permissions.Any(p => p.ParentId == permission.ParentId))
                                {

#line default
#line hidden
                BeginContext(2977, 42, true);
                WriteLiteral("                                    <ul>\r\n");
                EndContext();
#line 70 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
                                         foreach (var sub in permissions.Where(p => p.ParentId == permission.PermissionId))
                                        {

#line default
#line hidden
                BeginContext(3187, 121, true);
                WriteLiteral("                                            <li>\r\n                                                <input type=\"checkbox\" ");
                EndContext();
                BeginContext(3310, 62, false);
#line 73 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
                                                                   Write((SelectedPermissions.Any(p=>p==sub.PermissionId)?"checked":""));

#line default
#line hidden
                EndContext();
                BeginContext(3373, 34, true);
                WriteLiteral(" name=\"SelectedPermission\" value=\"");
                EndContext();
                BeginContext(3408, 16, false);
#line 73 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
                                                                                                                                                                     Write(sub.PermissionId);

#line default
#line hidden
                EndContext();
                BeginContext(3424, 4, true);
                WriteLiteral("\"/> ");
                EndContext();
                BeginContext(3429, 19, false);
#line 73 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
                                                                                                                                                                                          Write(sub.PermissionTitle);

#line default
#line hidden
                EndContext();
                BeginContext(3448, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 74 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
                                                 if (permissions.Any(p => p.ParentId == sub.ParentId))
                                                {

#line default
#line hidden
                BeginContext(3605, 60, true);
                WriteLiteral("                                                    <ul>\r\n\r\n");
                EndContext();
#line 78 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
                                                         foreach (var sub2 in permissions.Where(p => p.ParentId == sub.PermissionId))
                                                        {

#line default
#line hidden
                BeginContext(3859, 153, true);
                WriteLiteral("                                                            <li>\r\n                                                                <input type=\"checkbox\" ");
                EndContext();
                BeginContext(4014, 63, false);
#line 81 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
                                                                                   Write((SelectedPermissions.Any(p=>p==sub2.PermissionId)?"checked":""));

#line default
#line hidden
                EndContext();
                BeginContext(4078, 34, true);
                WriteLiteral(" name=\"SelectedPermission\" value=\"");
                EndContext();
                BeginContext(4113, 17, false);
#line 81 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
                                                                                                                                                                                      Write(sub2.PermissionId);

#line default
#line hidden
                EndContext();
                BeginContext(4130, 4, true);
                WriteLiteral("\"/> ");
                EndContext();
                BeginContext(4135, 20, false);
#line 81 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
                                                                                                                                                                                                            Write(sub2.PermissionTitle);

#line default
#line hidden
                EndContext();
                BeginContext(4155, 69, true);
                WriteLiteral("\r\n                                                            </li>\r\n");
                EndContext();
#line 83 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
                                                        }

#line default
#line hidden
                BeginContext(4283, 59, true);
                WriteLiteral("                                                    </ul>\r\n");
                EndContext();
#line 85 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
                                                }

#line default
#line hidden
                BeginContext(4393, 51, true);
                WriteLiteral("                                            </li>\r\n");
                EndContext();
#line 87 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
                                        }

#line default
#line hidden
                BeginContext(4487, 43, true);
                WriteLiteral("                                    </ul>\r\n");
                EndContext();
#line 89 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
                                }

#line default
#line hidden
                BeginContext(4565, 35, true);
                WriteLiteral("                            </li>\r\n");
                EndContext();
#line 91 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Edit.cshtml"
                        }

#line default
#line hidden
                BeginContext(4627, 95, true);
                WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4729, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4764, 479, true);
                WriteLiteral(@"
    <script>
        function readURL(input) {

            if (input.files && input.files[0]) {
                var reader = new FileReader();

                reader.onload = function(e) {
                    $('#imgAvatar').attr('src', e.target.result);
                }

                reader.readAsDataURL(input.files[0]);
            }
        }

        $(""#Model_UserAvatar"").change(function() {
            readURL(this);
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErfanLearn.Web.Pages.Admin.Roles.EditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErfanLearn.Web.Pages.Admin.Roles.EditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErfanLearn.Web.Pages.Admin.Roles.EditModel>)PageContext?.ViewData;
        public ErfanLearn.Web.Pages.Admin.Roles.EditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
