#pragma checksum "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "353e17addd01f51c6a42d50fb32619f2cf498c7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"353e17addd01f51c6a42d50fb32619f2cf498c7c", @"/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da19c4b16b29ae1c5018fedbda5ddbae5a75d409", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DocumentManagement.Models.ViewModels.DocumentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Department", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadIt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropzone"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("UploadForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
  
    //Department Index
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .table-striped tbody tr:nth-of-type(2n+1) {
        background-color: #ecf3f9 !important;
    }

    .table-striped tbody tr:nth-of-type(2n) {
        background-color: #f5f9fc !important;
    }
</style>

<div class=""row px-3 px-md-5 pb-4 mb-4 company"" id=""main-content"">

    <h5 class=""text-primary font-weight-bold text-capitalize""></h5>

    <div class=""col-12 px-0"">

        <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">

            <li class=""nav-item"">
                <a class=""nav-link active"" id=""view-tab"" data-toggle=""tab"" href=""#view"" role=""tab"" aria-controls=""view"" aria-selected=""true"">View Documents</a>
            </li>

            <li class=""nav-item"">
                <a class=""nav-link"" id=""add-tab"" data-toggle=""tab"" href=""#add"" role=""tab"" aria-controls=""add"" aria-selected=""false"">Upload Documents+</a>
            </li>

        </ul>

        <div class=""tab-content mt-3"" id=""myTabContent"">

            <div class=""tab-pane fade show active sha");
            WriteLiteral(@"dow"" id=""view"" role=""tabpanel"" aria-labelledby=""view-tab"">
                <div class=""row px-2"">
                    <div class=""col-12 px-4 py-3 mb-3"">

                        <div class=""row"">

                            <div class=""col-6"">
                                <h5>View All Documents</h5>
                            </div>


                            <div class=""col-6 text-right"">
");
            WriteLiteral("                            </div>\r\n                        </div>\r\n\r\n");
#nullable restore
#line 57 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
                         if (TempData["Success"] != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"row\">\r\n                                <div class=\"col-8\">\r\n                                    <div class=\"alert alert-success\" role=\"alert\">\r\n                                        ");
#nullable restore
#line 62 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
                                   Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 66 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
                         if (TempData["Failure"] != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"row\">\r\n                                <div class=\"col-8\">\r\n                                    <div class=\"alert alert-warning\" role=\"alert\">\r\n                                        ");
#nullable restore
#line 72 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
                                   Write(TempData["Failure"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 76 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        <table id=""dataTable"" class=""table table-striped table-borderless pt-2"">
                            <thead style=""background-color:black"">
                                <tr class=""text-white"">
                                    <th>ID</th>
                                    <th>Name</th>
                                    <th>Uploaded by</th>
                                    <th>View</th>
                                </tr>
                            </thead>

                            <tbody>
");
#nullable restore
#line 90 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
                                 foreach (DocumentManagement.Models.ViewModels.DocumentDetail detail in Model.DocumentDetails)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"align-middle\">");
#nullable restore
#line 93 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
                                                            Write(detail.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"align-middle\">");
#nullable restore
#line 94 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
                                                            Write(detail.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"align-middle\">");
#nullable restore
#line 95 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
                                                            Write(detail.UploadedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 96 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
                                         if (detail.FileType == ".txt")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"align-middle\"><a class=\"btn btn-outline-dark\"");
            BeginWriteAttribute("href", " href=\"", 4118, "\"", 4175, 2);
            WriteAttributeValue("", 4125, "http://dms.jointintelgroup.com/", 4125, 31, true);
#nullable restore
#line 98 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
WriteAttributeValue("", 4156, detail.DisplayPath, 4156, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" download>Download</a></td>\r\n");
#nullable restore
#line 99 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
                                        }
                                        else
                              if (detail.FileType == ".pdf")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"align-middle\"><a class=\"btn btn-outline-dark\"");
            BeginWriteAttribute("href", " href=\"", 4499, "\"", 4556, 2);
            WriteAttributeValue("", 4506, "http://dms.jointintelgroup.com/", 4506, 31, true);
#nullable restore
#line 103 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
WriteAttributeValue("", 4537, detail.DisplayPath, 4537, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">View</a></td>\r\n");
#nullable restore
#line 104 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
                                        }
                                        else
                                   if (detail.FileType == ".jpeg" || detail.FileType == ".jpg" || detail.FileType == ".png")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"align-middle\"><a class=\"btn btn-outline-dark\"");
            BeginWriteAttribute("href", " href=\"", 4947, "\"", 5004, 2);
            WriteAttributeValue("", 4954, "http://dms.jointintelgroup.com/", 4954, 31, true);
#nullable restore
#line 108 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
WriteAttributeValue("", 4985, detail.DisplayPath, 4985, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">View</a></td>\r\n");
#nullable restore
#line 109 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
                                        }
                                        else
                              if (detail.FileType == ".docx" || detail.FileType == ".docm" || detail.FileType == ".dotm" || detail.FileType == ".dotx")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"align-middle\"><a class=\"btn btn-outline-dark\"");
            BeginWriteAttribute("href", " href=\"", 5422, "\"", 5530, 2);
            WriteAttributeValue("", 5429, "https://view.officeapps.live.com/op/embed.aspx?src=http://dms.jointintelgroup.com/", 5429, 82, true);
#nullable restore
#line 113 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
WriteAttributeValue("", 5511, detail.DisplayPath, 5511, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">View</a></td>\r\n");
#nullable restore
#line 114 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
                                        }
                                        else
                              if (detail.FileType == ".xlsx" || detail.FileType == ".xlsb" || detail.FileType == ".xls" || detail.FileType == ".xlsm")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"align-middle\"><a class=\"btn btn-outline-dark\"");
            BeginWriteAttribute("href", " href=\"", 5947, "\"", 6055, 2);
            WriteAttributeValue("", 5954, "https://view.officeapps.live.com/op/embed.aspx?src=http://dms.jointintelgroup.com/", 5954, 82, true);
#nullable restore
#line 118 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
WriteAttributeValue("", 6036, detail.DisplayPath, 6036, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">View</a></td>\r\n");
#nullable restore
#line 119 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
                                        }
                                        else
                              if (detail.FileType == ".pptx" || detail.FileType == ".ppsx" || detail.FileType == ".ppt" || detail.FileType == ".pps" || detail.FileType == ".pptm" || detail.FileType == ".potm" || detail.FileType == ".ppam" || detail.FileType == ".potx" || detail.FileType == ".ppsm")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"align-middle\"><a class=\"btn btn-outline-dark\"");
            BeginWriteAttribute("href", " href=\"", 6621, "\"", 6729, 2);
            WriteAttributeValue("", 6628, "https://view.officeapps.live.com/op/embed.aspx?src=http://dms.jointintelgroup.com/", 6628, 82, true);
#nullable restore
#line 123 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
WriteAttributeValue("", 6710, detail.DisplayPath, 6710, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">View</a></td>\r\n");
#nullable restore
#line 124 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"align-middle\"><a class=\"btn btn-outline-dark\"");
            BeginWriteAttribute("href", " href=\"", 6994, "\"", 7085, 2);
            WriteAttributeValue("", 7001, "https://docs.google.com/gview?url=http://dms.jointintelgroup.com/", 7001, 65, true);
#nullable restore
#line 127 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
WriteAttributeValue("", 7066, detail.DisplayPath, 7066, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">View</a></td>\r\n");
#nullable restore
#line 128 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tr>\r\n");
#nullable restore
#line 130 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </tbody>
                        </table>


                    </div>
                </div>
            </div>

            <div class=""tab-pane fade shadow col-8"" id=""add"" role=""tabpanel"" aria-labelledby=""add-tab"">
                <div class=""row px-2"">
                    <div class=""col-12 px-4 py-3 mb-3"">


                        <div class=""row mb-4"">
                            <div class=""col-12"">
                                <h5 class=""text-capitalize"">Add New Document</h5>
                            </div>
                        </div>


                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "353e17addd01f51c6a42d50fb32619f2cf498c7c20300", async() => {
                WriteLiteral(@"
                            <div class=""fallback"">
                                <input name=""file"" type=""file"" multiple />
                                <input type=""submit"" value=""Upload"" />
                            </div>
                        ");
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
#line 152 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">

        function OnSubmitClick() {
            // Initialize form validation on the registration form.
            // It has the name attribute ""registration""
            $(""form[name='AddCompanyForm']"").validate({
                // Specify validation rules
                rules: {
                    // The key name on the left side is the name attribute
                    // of an input field. Validation rules are defined
                    // on the right side
                    Name: ""required"",
                    PhoneNo: {
                        //required: true,
                        number: true
                    },
                    //Address: ""required"",
                    Email: {
                        //required: true,
                        // Specify that email should be validated
                        // by the built-in ""email"" rule
                        email: true
                    },
                },
     ");
                WriteLiteral(@"           // Specify validation error messages
                messages: {
                    Name: ""Please enter company name"",
                    PhoneNo: ""Please enter valid number"",
                    //Address: ""Please enter company name"",
                    Email: ""Please enter correct email"",
                },
                // Make sure the form is submitted to the destination defined
                // in the ""action"" attribute of the form when valid
                submitHandler: function (form) {
                    form.submit();
                }
            });
            var $form = $(""form[name='AddCompanyForm']"");
            if (!$form.valid()) { return false; }
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DocumentManagement.Models.ViewModels.DocumentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
