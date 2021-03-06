#pragma checksum "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d501f9326e3f37deb261c2ef22a94621447f1d2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Shared), @"mvc.1.0.view", @"/Views/Admin/Shared.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d501f9326e3f37deb261c2ef22a94621447f1d2a", @"/Views/Admin/Shared.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da19c4b16b29ae1c5018fedbda5ddbae5a75d409", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Shared : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DocumentManagement.Models.ViewModels.DocumentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
  
    //Admin Shared
    ViewData["Title"] = "Shared";
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

        </ul>

        <div class=""tab-content mt-3"" id=""myTabContent"">

            <div class=""tab-pane fade show active shadow"" id=""view"" role=""tabpanel"" aria-labelledby=""view-tab"">
                <div class=""row px-2"">
                    <div class=""col-12 px-4 py-3 mb-3"">

                        <div class=""row"">

       ");
            WriteLiteral("                     <div class=\"col-6\">\r\n                                <h5>View All Documents</h5>\r\n                            </div>\r\n\r\n\r\n                            <div class=\"col-6 text-right\">\r\n");
            WriteLiteral("                            </div>\r\n                        </div>\r\n\r\n");
#nullable restore
#line 53 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
                         if (TempData["Success"] != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"row\">\r\n                                <div class=\"col-8\">\r\n                                    <div class=\"alert alert-success\" role=\"alert\">\r\n                                        ");
#nullable restore
#line 58 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
                                   Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 62 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
                         if (TempData["Failure"] != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"row\">\r\n                                <div class=\"col-8\">\r\n                                    <div class=\"alert alert-warning\" role=\"alert\">\r\n                                        ");
#nullable restore
#line 68 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
                                   Write(TempData["Failure"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 72 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        <table id=""dataTable"" class=""table table-striped table-borderless pt-2"">
                            <thead style=""background-color:black;"">
                                <tr class=""text-white"">
                                    <th>ID</th>
                                    <th>Name</th>
                                    <th>Shared by</th>
                                    <th>View</th>
                                </tr>
                            </thead>

                            <tbody>
");
#nullable restore
#line 86 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
                                 foreach (DocumentManagement.Models.ViewModels.DocumentDetail detail in Model.DocumentDetails)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"align-middle\">");
#nullable restore
#line 89 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
                                                            Write(detail.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"align-middle\">");
#nullable restore
#line 90 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
                                                            Write(detail.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"align-middle\">");
#nullable restore
#line 91 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
                                                            Write(detail.UploadedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 92 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
                                         if (detail.FileType == ".txt")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"align-middle\"><a class=\"btn btn-outline-dark\"");
            BeginWriteAttribute("href", " href=\"", 3903, "\"", 3960, 2);
            WriteAttributeValue("", 3910, "http://dms.jointintelgroup.com/", 3910, 31, true);
#nullable restore
#line 94 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
WriteAttributeValue("", 3941, detail.DisplayPath, 3941, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" download>Download</a></td>\r\n");
#nullable restore
#line 95 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
                                        }
                                        else
                              if (detail.FileType == ".pdf")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"align-middle\"><a class=\"btn btn-outline-dark\"");
            BeginWriteAttribute("href", " href=\"", 4284, "\"", 4341, 2);
            WriteAttributeValue("", 4291, "http://dms.jointintelgroup.com/", 4291, 31, true);
#nullable restore
#line 99 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
WriteAttributeValue("", 4322, detail.DisplayPath, 4322, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">View</a></td>\r\n");
#nullable restore
#line 100 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
                                        }
                                        else
                                   if (detail.FileType == ".jpeg" || detail.FileType == ".jpg" || detail.FileType == ".png")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"align-middle\"><a class=\"btn btn-outline-dark\"");
            BeginWriteAttribute("href", " href=\"", 4732, "\"", 4789, 2);
            WriteAttributeValue("", 4739, "http://dms.jointintelgroup.com/", 4739, 31, true);
#nullable restore
#line 104 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
WriteAttributeValue("", 4770, detail.DisplayPath, 4770, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">View</a></td>\r\n");
#nullable restore
#line 105 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
                                        }
                                        else
                              if (detail.FileType == ".docx" || detail.FileType == ".docm" || detail.FileType == ".dotm" || detail.FileType == ".dotx")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"align-middle\"><a class=\"btn btn-outline-dark\"");
            BeginWriteAttribute("href", " href=\"", 5207, "\"", 5315, 2);
            WriteAttributeValue("", 5214, "https://view.officeapps.live.com/op/embed.aspx?src=http://dms.jointintelgroup.com/", 5214, 82, true);
#nullable restore
#line 109 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
WriteAttributeValue("", 5296, detail.DisplayPath, 5296, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">View</a></td>\r\n");
#nullable restore
#line 110 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
                                        }
                                        else
                              if (detail.FileType == ".xlsx" || detail.FileType == ".xlsb" || detail.FileType == ".xls" || detail.FileType == ".xlsm")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"align-middle\"><a class=\"btn btn-outline-dark\"");
            BeginWriteAttribute("href", " href=\"", 5732, "\"", 5840, 2);
            WriteAttributeValue("", 5739, "https://view.officeapps.live.com/op/embed.aspx?src=http://dms.jointintelgroup.com/", 5739, 82, true);
#nullable restore
#line 114 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
WriteAttributeValue("", 5821, detail.DisplayPath, 5821, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">View</a></td>\r\n");
#nullable restore
#line 115 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
                                        }
                                        else
                              if (detail.FileType == ".pptx" || detail.FileType == ".ppsx" || detail.FileType == ".ppt" || detail.FileType == ".pps" || detail.FileType == ".pptm" || detail.FileType == ".potm" || detail.FileType == ".ppam" || detail.FileType == ".potx" || detail.FileType == ".ppsm")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"align-middle\"><a class=\"btn btn-outline-dark\"");
            BeginWriteAttribute("href", " href=\"", 6406, "\"", 6514, 2);
            WriteAttributeValue("", 6413, "https://view.officeapps.live.com/op/embed.aspx?src=http://dms.jointintelgroup.com/", 6413, 82, true);
#nullable restore
#line 119 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
WriteAttributeValue("", 6495, detail.DisplayPath, 6495, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">View</a></td>\r\n");
#nullable restore
#line 120 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"align-middle\"><a class=\"btn btn-outline-dark\"");
            BeginWriteAttribute("href", " href=\"", 6779, "\"", 6870, 2);
            WriteAttributeValue("", 6786, "https://docs.google.com/gview?url=http://dms.jointintelgroup.com/", 6786, 65, true);
#nullable restore
#line 123 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
WriteAttributeValue("", 6851, detail.DisplayPath, 6851, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">View</a></td>\r\n");
#nullable restore
#line 124 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tr>\r\n");
#nullable restore
#line 126 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Admin\Shared.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
