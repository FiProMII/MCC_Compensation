#pragma checksum "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Request\Requester.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e664cd8372c3c5ea4369c46a0296b78e64d59f6b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e664cd8372c3c5ea4369c46a0296b78e64d59f6b", @"/Views/Request/Requester.cshtml")]
    public class Views_Request_Requester : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Request\Requester.cshtml"
   Layout = "_Layout";
    ViewBag.Title = "Compensation Request";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""card-title"">
                <br /><h4 class=""card-title""><i class=""fas fa-clipboard-list""></i> Compensation Request</h4>
            </div>
        </div>
    </div>
</div>
<div class=""flex-md-wrap"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card m-auto"">
                    <div class=""card-body"" style=""padding-left: 100px; padding-right: 100px;"">
                        <br />
                        <h4>Requester Information</h4>
                        <hr />
                        <div class=""form-group row"">
                            <label class=""col-md-4"">Requester</label>
                            <span class=""col-md-7"" id=""Requester""></span>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-md-4"">Department");
            WriteLiteral(@"</label>
                            <span class=""col-md-7"" id=""DepartmentName""></span>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-md-4"">Position</label>
                            <span class=""col-md-7"" id=""PositionName""></span>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-md-4"">Relation Manager</label>
                            <span class=""col-md-7"" id=""ManagerName""></span>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-md-4"">Join Date</label>
                            <span class=""col-md-7"" id=""ManagerName""></span>
                        </div>
                    </div>
                </div>
                <br />
                <div class=""card m-auto"">
                    <div class=""card-header"">Compensation Request</div>
 ");
            WriteLiteral(@"                   <form>
                        <div class=""card-body"" style=""padding-left: 100px; padding-right: 100px;"">
                            <div class=""form-group row"">
                                <label class=""col-md-4 col-form-label"">Requester Number</label>
                                <div class=""col-md-7 col-form-label"">
                                    <span>Request ID</span>
                                    <input type=""hidden"" value=""requestID"" name=""RequestID"" id=""RequestID"" />
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-md-4 col-form-label"">Compensation Type</label>
                                <div class=""col-md-3"">
                                    <select class=""form-control"" id=""groupType"" name=""groupType"">
                                        <!-- <option value="""">Compensation Name</option>-->
                   ");
            WriteLiteral(@"                 </select>
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-md-4 col-form-label"">Event Date</label>
                                <div class=""col-md-3"">
                                    <input type=""date"" class=""form-control"" name=""EventDate"" id=""EventDate"">
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-md-4 col-form-label"">Document Requirements</label>
                                <div class=""col-md-7 col-form-label"">
                                    <span>1. Wedding Gift: KK & KTP</span><br />
                                    <span>2. Baby Gift: KK</span><br />
                                    <span>3. Duka: KK</span><br />
                                </div>
                            </div>
            WriteLiteral(@"
                            <div class=""form-group row"">
                                <label class=""col-md-4 col-form-label"">
                                    Upload Requirement Files <br />
                                    <span style=""color:red; font-size:12px"">Allowed extensions .jpg | .jpeg | .pdf</span>
                                </label>
                                <div class=""col-md-7 col-form-label bag"">
                                    <div class='element' id='div_1'>
                                        <input type=""file"" name=""file"" class=""custom-file"" id=""txt_1"" accept=""image/jpg, image/jpeg, .pdf"" />
                                        <span class=""add btn btn-sm btn-outline-success"">Add Document</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <div class=""col-12 text-ri");
            WriteLiteral(@"ght pr-5"">
                                <button class=""btn btn-primary"" type=""submit"">Submit</button>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {

            $("".add"").click(function () {

                var total_element = $("".element"").length;

                var lastid = $("".element:last"").attr(""id"");
                var split_id = lastid.split(""_"");
                var nextindex = Number(split_id[1]) + 1;

                var max = 2;

                if (total_element < max) {

                    $("".element:last"").after(""<div class='element' id='div_"" + nextindex + ""'></div>"");

                    $(""#div_"" + nextindex).append(""<br/><input type='file' name='file' class='custom-file' id='txt_""
                        + nextindex + ""' accept='image/jpg, image/jpeg, .pdf' /><br /><span id='remove_""
                        + nextindex + ""' class='remove btn btn-sm btn-outline-danger'>Abort</span>"");
                }

            });

            $('.bag').on('click', '.remove', function () {

                var id = this.id;
                var split_id = id.spli");
                WriteLiteral("t(\"_\");\r\n                var deleteindex = split_id[1];\r\n\r\n                $(\"#div_\" + deleteindex).remove();\r\n\r\n            });\r\n        });\r\n    </script>\r\n");
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