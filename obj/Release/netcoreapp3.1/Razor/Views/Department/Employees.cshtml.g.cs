#pragma checksum "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Employees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a045f3b5bfa5dd79045777a3a38440452af08f8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Employees), @"mvc.1.0.view", @"/Views/Department/Employees.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a045f3b5bfa5dd79045777a3a38440452af08f8c", @"/Views/Department/Employees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da19c4b16b29ae1c5018fedbda5ddbae5a75d409", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_Employees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DocumentManagement.Models.ViewModels.EmployeeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Employees.cshtml"
  
    ViewData["Title"] = "Employees";
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

    <h5 class=""text-primary font-weight-bold text-capitalize"">Employees</h5>

    <div class=""col-12 px-0"">

        <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">

            <li class=""nav-item"">
                <a class=""nav-link active"" id=""view-tab"" data-toggle=""tab"" href=""#view"" role=""tab"" aria-controls=""view"" aria-selected=""true"">View Employees</a>
            </li>

");
            WriteLiteral(@"
        </ul>

        <div class=""tab-content mt-3"" id=""myTabContent"">

            <div class=""tab-pane fade show active shadow"" id=""view"" role=""tabpanel"" aria-labelledby=""view-tab"">
                <div class=""row px-2"">
                    <div class=""col-12 px-4 py-3 mb-3"">

                        <div class=""row"">

                            <div class=""col-6"">
                                <h5>View All Employees</h5>
                            </div>

                            <div class=""col-6 text-right"">
");
            WriteLiteral("                            </div>\r\n                        </div>\r\n\r\n");
#nullable restore
#line 57 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Employees.cshtml"
                         if (TempData["Success"] != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"row\">\r\n                                <div class=\"col-8\">\r\n                                    <div class=\"alert alert-success\" role=\"alert\">\r\n                                        ");
#nullable restore
#line 62 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Employees.cshtml"
                                   Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 66 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Employees.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Employees.cshtml"
                         if (TempData["Failure"] != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"row\">\r\n                                <div class=\"col-8\">\r\n                                    <div class=\"alert alert-warning\" role=\"alert\">\r\n                                        ");
#nullable restore
#line 72 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Employees.cshtml"
                                   Write(TempData["Failure"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 76 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Employees.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        <table id=""dataTable"" class=""table table-striped table-borderless pt-2"">
                            <thead style=""background-color: #0867b3;"">
                                <tr class=""text-white"">
                                    <th>ID</th>
                                    <th>Name</th>
                                    <th>Files</th>
                                </tr>
                            </thead>

                            <tbody>
");
#nullable restore
#line 89 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Employees.cshtml"
                                 foreach (DocumentManagement.Models.ViewModels.EmployeeDetail detail in Model.EmployeeDetails)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"align-middle\">");
#nullable restore
#line 92 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Employees.cshtml"
                                                            Write(detail.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"align-middle\">");
#nullable restore
#line 93 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Employees.cshtml"
                                                            Write(detail.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"align-middle\">");
#nullable restore
#line 94 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Employees.cshtml"
                                                            Write(Html.ActionLink("View", "Files", "Employee", new { employeeId = detail.ID }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 96 "C:\Users\Administrator\Desktop\DocumentManagement\DocumentManagement\Views\Department\Employees.cshtml"
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
                                <h5 class=""text-capitalize"">Add New Company</h5>
                            </div>
                        </div>




                    </div>
                </div>
            </div>

        </div>

    </div>

</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DocumentManagement.Models.ViewModels.EmployeeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
