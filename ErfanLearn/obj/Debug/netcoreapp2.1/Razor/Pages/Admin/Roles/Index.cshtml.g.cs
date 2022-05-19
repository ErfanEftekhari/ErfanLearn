#pragma checksum "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53997d7efc46ffb09a1b47eed8dbf80c1cab5ab0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Roles_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Roles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Roles/Index.cshtml", typeof(AspNetCore.Pages_Admin_Roles_Index), null)]
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
#line 2 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Index.cshtml"
using ErfanLearn.Core.Convertors;

#line default
#line hidden
#line 3 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Index.cshtml"
using ErfanLearn.Enum;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53997d7efc46ffb09a1b47eed8dbf80c1cab5ab0", @"/Pages/Admin/Roles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Roles_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(159, 1317, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <h1 class=""page-header"">لیست نقش ها</h1>
    </div>
    <!-- /.col-lg-12 -->
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                لیست نقش های سایت
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <div class=""table-responsive"">
                    <div id=""dataTables-example_wrapper"" class=""dataTables_wrapper form-inline"" role=""grid"">
                        <div class=""col-md-12"" style=""margin: 10px 0;"">

                            <a class=""btn btn-outline btn-success"" href=""/admin/roles/create"">افزودن نقش جدید</a>

                        </div>
                        <table class=""table table-striped table-bordered table-hover dataTable no-footer"" id=""dataTables-example"" aria-describedby=""dataTables-example_info"">
                            <thead>
                   ");
            WriteLiteral(@"             <tr>
                                    <th>نام نقش</th>
                                    <th>وضعیت</th>
                                    <th>دستورات</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 40 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Index.cshtml"
                                 foreach (var role in Model.Roles)
                                {

#line default
#line hidden
            BeginContext(1579, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(1666, 14, false);
#line 43 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Index.cshtml"
                                       Write(role.RoleTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1680, 53, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n");
            EndContext();
#line 45 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Index.cshtml"
                                             if (role.Status == Status.Enabled)
                                            {

#line default
#line hidden
            BeginContext(1861, 82, true);
            WriteLiteral("                                                <p class=\"text-success\">فعال</p>\r\n");
            EndContext();
#line 48 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Index.cshtml"
                                            }
                                            else if (role.Status == Status.Disabled)
                                            {

#line default
#line hidden
            BeginContext(2123, 85, true);
            WriteLiteral("                                                <p class=\"text-danger\">غیر فعال</p>\r\n");
            EndContext();
#line 52 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(2352, 84, true);
            WriteLiteral("                                                <p class=\"text-danger\">حذف شده</p>\r\n");
            EndContext();
#line 56 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(2483, 137, true);
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2620, 184, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53997d7efc46ffb09a1b47eed8dbf80c1cab5ab07961", async() => {
                BeginContext(2698, 102, true);
                WriteLiteral("\r\n                                                ویرایش\r\n                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Index.cshtml"
                                                                 WriteLiteral(role.RoleId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2804, 87, true);
            WriteLiteral("\r\n                                            <a href=\"#\" class=\"btn btn-danger btn-sm\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2891, "\"", 2925, 3);
            WriteAttributeValue("", 2901, "deleteFunc(", 2901, 11, true);
#line 62 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Index.cshtml"
WriteAttributeValue("", 2912, role.RoleId, 2912, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2924, ")", 2924, 1, true);
            EndWriteAttribute();
            BeginContext(2926, 196, true);
            WriteLiteral(">\r\n                                                حذف\r\n                                            </a>\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 67 "E:\Work\ErfanLearn\ErfanLearn\Pages\Admin\Roles\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3157, 1094, true);
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>

            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
    </div>
    <!-- /.col-lg-12 -->
</div>

<script type=""text/javascript"">

    function deleteFunc(roleId)
    {
      var url = '/api/admin/roles/DeleteRole/'+roleId;
        $.ajax({
            url: url,
            type: 'Post',
            dataType: 'json',
            async: true,
            success: function (data,result) {
                console.log(data);
                if(data.data == true)
                {
                    alert('با موفقیت حذف شد.');
                    document.location.href= '/admin/roles';
                }
                if(data.data == false)
                {
                    alert('خطایی به وجود آمده است');
                }
            },
            error: function(request, option, err) {
                alert('خطا");
            WriteLiteral("یی به وجود آمده است\');\r\n            }\r\n        });\r\n    }\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErfanLearn.Web.Pages.Admin.Roles.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErfanLearn.Web.Pages.Admin.Roles.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErfanLearn.Web.Pages.Admin.Roles.IndexModel>)PageContext?.ViewData;
        public ErfanLearn.Web.Pages.Admin.Roles.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591