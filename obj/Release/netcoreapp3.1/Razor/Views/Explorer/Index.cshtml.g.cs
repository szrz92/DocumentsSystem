#pragma checksum "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Explorer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30f155dc94e1d4b1dc9188a212e61870079e09c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Explorer_Index), @"mvc.1.0.view", @"/Views/Explorer/Index.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\_ViewImports.cshtml"
using DocumentManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\_ViewImports.cshtml"
using DocumentManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30f155dc94e1d4b1dc9188a212e61870079e09c2", @"/Views/Explorer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da19c4b16b29ae1c5018fedbda5ddbae5a75d409", @"/Views/_ViewImports.cshtml")]
    public class Views_Explorer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DocumentManagement.Models.Utilities.ExplorerModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadIt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropzone"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("UploadForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border:none; color:white;height:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Explorer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30f155dc94e1d4b1dc9188a212e61870079e09c25600", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-9\">\r\n            <div class=\"card m-3\"");
                BeginWriteAttribute("style", " style=\"", 422, "\"", 430, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                <div class=""card-header bg-primary container-fluid"">
                    <div class=""row"">
                        <div class=""col-md-9 text-white"">
                            <h5 class="" text-white"">
                                <i class=""fa fa-folder ""></i>
                                ");
#nullable restore
#line 16 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Explorer\Index.cshtml"
                           Write(Model.FolderName.Replace("/", ""));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </h5>\r\n                        </div>\r\n                        <div class=\"col-md-3 float-right\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 944, "\"", 983, 1);
#nullable restore
#line 20 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Explorer\Index.cshtml"
WriteAttributeValue("", 951, Url.Action("Index", "Explorer"), 951, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-small btn-primary ml-3\">\r\n                                <i class=\"ace-icon fa fa-home \"></i>\r\n                                Home\r\n                            </a>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 1198, "\"", 1269, 1);
#nullable restore
#line 24 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Explorer\Index.cshtml"
WriteAttributeValue("", 1205, Url.Action("Index", "Explorer", new { path = Model.ParentURL }), 1205, 64, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-small btn-primary ml-3"">
                                <i class=""ace-icon fa fa-arrow-left ""></i>
                                Back
                            </a>
                        </div>
                    </div>
                </div>
                <div class=""card-body"">
                    <h5 class=""card-title"">");
#nullable restore
#line 32 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Explorer\Index.cshtml"
                                      Write(Model.ParentFolderName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 35 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Explorer\Index.cshtml"
                         foreach (var item in Model.DirModelList)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-md-2 category-responsive\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 1899, "\"", 1991, 1);
#nullable restore
#line 38 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Explorer\Index.cshtml"
WriteAttributeValue("", 1906, Url.Action("Index", "Explorer", new { path = item.CurrentPath.Split("wwwroot")[1] }), 1906, 85, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""category-wrap"">
                                    <div class=""category-block"">
                                        <i class=""fa fa-folder category-img"" style=""font-size: 3.5em;"" aria-hidden=""true""></i>
                                        <h6>
                                            ");
#nullable restore
#line 42 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Explorer\Index.cshtml"
                                       Write(item.DirName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </h6>\r\n                                    </div>\r\n                                </a>\r\n                            </div>\r\n");
#nullable restore
#line 47 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Explorer\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Explorer\Index.cshtml"
                         foreach (var item in Model.FileModelList)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-md-2 category-responsive\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 2711, "\"", 2735, 1);
#nullable restore
#line 52 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Explorer\Index.cshtml"
WriteAttributeValue("", 2718, item.CurrentPath, 2718, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""category-wrap"">
                                    <div class=""category-block"">
                                        <i class=""fa fa-file category-img"" style=""font-size: 3.5em;"" aria-hidden=""true""></i>
                                        <h6>
                                            ");
#nullable restore
#line 56 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Explorer\Index.cshtml"
                                       Write(item.FileName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </h6>\r\n                                    </div>\r\n                                </a>\r\n                            </div>\r\n");
#nullable restore
#line 61 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Explorer\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"col-3\">\r\n            \r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 6 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Explorer\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DocumentManagement.Models.Utilities.ExplorerModel> Html { get; private set; }
    }
}
#pragma warning restore 1591