#pragma checksum "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Request\Requester.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3abf50a9222d6dfeac49ee4fc85599e10683cf4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_Requester), @"mvc.1.0.view", @"/Views/Request/Requester.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3abf50a9222d6dfeac49ee4fc85599e10683cf4e", @"/Views/Request/Requester.cshtml")]
    public class Views_Request_Requester : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Request\Requester.cshtml"
   Layout = "_LayoutAdmin";
    ViewBag.Title = "New Request";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- ============================================================== -->
<!-- Container fluid  -->
<!-- ============================================================== -->
<div class=""container-fluid"">
    <!-- ============================================================== -->
    <!-- Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <div class=""row page-titles"">
        <div class=""col-md-6 col-8 align-self-center"">
            <h3 class=""text-themecolor m-b-0 m-t-0"">");
#nullable restore
#line 14 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Request\Requester.cshtml"
                                               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <ol class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item\"><a href=\"/Dashboard/Index\">Home</a></li>\r\n                <li class=\"breadcrumb-item active\">");
#nullable restore
#line 17 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Request\Requester.cshtml"
                                              Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
            </ol>
        </div>
        <div class=""col-md-6 col-4 align-self-center"">
            <a href=""/Request/Index"" class=""btn pull-right hidden-sm-down btn-outline-secondary""><i class=""mdi mdi-keyboard-backspace""></i> Back</a>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- End Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- Start Page Content -->
    <!-- ============================================================== -->
    <!-- Row -->
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""card card-outline-info"">
                <div class=""card-header"">
                    <h4 class=""m-b-0 text-white"">");
#nullable restore
#line 35 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Request\Requester.cshtml"
                                            Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                </div>
                <div class=""card-body"">
                    <form class=""form-horizontal"" role=""form"" id=""form"">
                        <div class=""form-body"">
                            <h3 class=""box-title m-t-40"">New Request</h3>
                            <hr>
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label>Compensation Type</label>
                                        <select class=""form-control custom-select"" id=""CompensationID"" name=""CompensationID""></select>
                                    </div>
                                </div>
                                <!--/span-->
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label>Event Date</label>
                              ");
            WriteLiteral(@"          <input type=""date"" class=""form-control"" id=""EventDate"" name=""EventDate"">
                                        <small class=""text-danger"" id=""errorMessage""></small>
                                    </div>
                                </div>
                                <!--/span-->
                            </div>
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""form-group"" id=""compensationDetail"">
                                    </div>
                                </div>
                                <div class=""col-md-6 bag"">
                                    <div class='element' id='div_1'>
                                        <div class=""form-group"">
                                            <label>File Upload</label> 
                                            <div class=""add btn btn-sm btn-outline-success pull-right"">Add File</div>
                  ");
            WriteLiteral(@"                          <div class=""controls"">
                                                <input type=""file"" name=""file"" class=""custom-file form-control"" id=""txt_1"" accept=""image/jpg, image/jpeg, .pdf"" />
                                                <span class=""text-danger"">upload KK</span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""card-footer"">
                            <a type=""button"" class=""btn btn-outline-dark waves-effect waves-light"" href=""/Request/Index"">Cancel</a>
                            <button type=""submit"" class=""btn btn-success waves-effect waves-light""><i class=""fa fa-check""></i> Send Request</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>");
            WriteLiteral("\n    <!-- Row -->\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        var compensationID

        let compensationValue = new Map()
        let compensationRequirement = new Map()

        $(document).ready(function () {

            compensationRequirement.set(""Wedding Gift"", ""KK & KTP"")
            compensationRequirement.set(""Baby Gift"", ""KK"")
            compensationRequirement.set(""Grief"", ""KK"")

            var compensationDropdown = '<option value=""-1"">Please select a compensation type</option>';

            $.ajax({
                type: ""GET"",
                url: '/Compensation/Get',
                headers: { 'Authorization': 'Bearer ' + localStorage.token },
                success: function (result) {
                    var data = result['result']
                    console.log(data.length)
                    for (var i = 0; i < data.length; i++) {
                        compensationDropdown += '<option value=""' + data[i].compensationID + '"">' + data[i].compensationName + '</option>';
                        compen");
                WriteLiteral(@"sationValue.set(data[i].compensationName, data[i].cost)
                    }
                    $(""#CompensationID"").html(compensationDropdown);
                }
            });

            $("".add"").click(function () {
                var total_element = $("".element"").length;
                var lastid = $("".element:last"").attr(""id"");
                var split_id = lastid.split(""_"");
                var nextindex = Number(split_id[1]) + 1;
                var max = 2;

                if (total_element < max) {
                    $("".element:last"").after(""<div class='element' id='div_"" + nextindex + ""'></div>"");
                    $(""#div_"" + nextindex).append(""<div class='form-group'><div id='remove_""
                        + nextindex + ""' class='remove btn btn-sm btn-outline-danger pull-right'>Abort</div>""
                        + ""<div class='controls'><input type='file' name='file' class='custom-file form-control' id='txt_""
                        + nextindex + ""' accept='image");
                WriteLiteral(@"/jpg, image/jpeg, .pdf' required /></div>""
                        + ""<span class='text-danger'>upload KTP</span >"");
                }
            });

            $('.bag').on('click', '.remove', function () {
                var id = this.id;
                var split_id = id.split(""_"");
                var deleteindex = split_id[1];

                $(""#div_"" + deleteindex).remove();
            });
        });

        function ValidateDED() {
            var dateString = new Date($('#EventDate').val());
            var dateNow = new Date();
            if ($('#EventDate').val() == """") {
                $('#EventDate').focus();
                $('#messageError').html(""The date is <code>Incorrect.</code>"");
            } else if (dateNow.getFullYear() - dateString.getFullYear() == 0) {
                alert('Please set another Date');
                $('#EventDate').val('');
                $('#messageError').html(""The date is <code>Incorrect.</code>"");
            }
            $");
                WriteLiteral(@"('#messageError').html("""");
        }

        $(""select#CompensationID"").on('change', function () {
            var selectedCompensationText = $('#CompensationID option:selected').text();
            compensationID = parseInt($('#CompensationID option:selected').val());
            var compensationDetail = '<label class=""col-md-4 col-form-label"">Document Details</label>' +
                '<div class=""col-md-7 col-form-label"" >' +
                '<span>Requirement: ' + compensationRequirement.get(selectedCompensationText) + '</span><br />' +
                '<span>Value: ' + compensationValue.get(selectedCompensationText) + '</span></div>'
            $('#compensationDetail').html(compensationDetail)
        })

        $('#form').submit(function (event) {
            event.preventDefault()
            var formData = new FormData($(this)[0]);
            formData.append('compensationID', compensationID)
            formData.append('eventDate', $('#EventDate').val())
            $.ajax({
 ");
                WriteLiteral(@"               url: '/Document/Post',
                type: 'POST',
                data: formData,
                headers: { 'Authorization': 'Bearer ' + localStorage.token },
                async: false,
                cache: false,
                contentType: false,
                enctype: 'multipart/form-data',
                processData: false,
                beforeSend: function (response) {
                    Swal.fire({
                        title: 'Please Wait !',
                        html: 'Your request is being processed',
                        allowOutsideClick: false,
                        showConfirmButton: false,
                        willOpen: () => {
                            Swal.showLoading()
                        }
                    })
                },
                success: function (response) {
                    Swal.fire({
                        title: '<strong>Congrats</strong>',
                        icon: 'info',
             ");
                WriteLiteral(@"           html:
                            'You have succesfully <b>send new request</b>, ' +
                            'please wait for managers ' +
                            'Approval',
                        showCloseButton: true,
                        focusConfirm: false,
                        confirmButtonText:
                            '<i class=""fa fa-thumbs-up""></i> Great!',
                        confirmButtonAriaLabel: 'Thumbs up, great!',
                        allowOutsideClick: false,
                    }).then((result) => {
                        if (result.isConfirmed) {
                            window.location.href = """);
#nullable restore
#line 213 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Request\Requester.cshtml"
                                               Write(Url.Action("Index", "Request"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n                        }\r\n                    })\r\n                }\r\n            });\r\n        })\r\n\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
