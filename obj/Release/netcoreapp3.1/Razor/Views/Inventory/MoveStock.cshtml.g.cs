#pragma checksum "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\MoveStock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f520c582c045365ce2845aab869a5c37563f3523"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventory_MoveStock), @"mvc.1.0.view", @"/Views/Inventory/MoveStock.cshtml")]
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
#line 1 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\_ViewImports.cshtml"
using SCASA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\_ViewImports.cshtml"
using SCASA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f520c582c045365ce2845aab869a5c37563f3523", @"/Views/Inventory/MoveStock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f59c02fdbf6895e021479e28253e13dd514c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory_MoveStock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SCASA.Models.ModelClasses.StockMovementMasterModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Inventory/All"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Warehouse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Showroom", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "StandBY", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Inventory/MoveStock"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmStock"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""header-icon"">
            <i class=""fa fa-dashboard""></i>
        </div>
        <div class=""header-title"">
            <h1>Stock Movement Process</h1>
            <small>Stock Management</small>
        </div>
    </section>
    <!-- Main content -->
    <div class=""content"">
        <div class=""row"">
            <!-- Form controls -->
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f520c582c045365ce2845aab869a5c37563f35236656", async() => {
                WriteLiteral(@"


                <div class=""col-sm-12"">
                    <div class=""card all_btn_card"" id=""lobicard-custom-control1"" data-sortable=""true"">
                        <div class=""card-header all_card_btn"">
                            <div class=""row"">
                                <div class=""col-md-2"">
                                    <div class=""card-title custom_title"">
                                        <h4>Move Stock</h4>
                                    </div>
                                </div>
                                <div class=""col-md-10"">
                                    <div class=""card-title custom_title pull-right"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f520c582c045365ce2845aab869a5c37563f35237652", async() => {
                    WriteLiteral("Back to list");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </div>
                                </div>
                            </div>

                        </div>
                        <div class=""card-body"">
                            <h3>Moving Stock </h3>
                            <br />

                            ");
#nullable restore
#line 41 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\MoveStock.cshtml"
                       Write(Html.HiddenFor(m => m.SMRId));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <label>Move From</label>
                                    <select class=""form-control"" name=""MovedFrom"" id=""movedFromD"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f520c582c045365ce2845aab869a5c37563f35239822", async() => {
                    WriteLiteral("Warehouse");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f520c582c045365ce2845aab869a5c37563f352311088", async() => {
                    WriteLiteral("Showroom");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </select>

                                </div>
                            </div>
                            <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <label>Move To</label>
                                    <select class=""form-control"" name=""MovedTo"" id=""movedToD"" onchange=""CheckStandBY()"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f520c582c045365ce2845aab869a5c37563f352312782", async() => {
                    WriteLiteral("Warehouse");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f520c582c045365ce2845aab869a5c37563f352314049", async() => {
                    WriteLiteral("Showroom");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f520c582c045365ce2845aab869a5c37563f352315315", async() => {
                    WriteLiteral("Stand By");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </select>
                                </div>
                            </div>
                            <div class=""col-sm-3"" id=""CustOptin"">
                                <div class=""form-group"">
                                    <label>Select Customer</label>
                                    ");
#nullable restore
#line 66 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\MoveStock.cshtml"
                               Write(Html.DropDownListFor(x => Model.customerID, new SelectList(ViewBag.customers, "cusId", "Name", Model.customerID), new { @id = "subcatDD", @class = "form-control select2", @onchange = "SelectGst()" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-sm-3"">

                                <div class=""form-group"">
                                    <label>References/Notes</label>
                                    <input type=""text"" name=""Remarks"" class=""form-control"" id=""MoStNot"" />
                                    ");
#nullable restore
#line 74 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\MoveStock.cshtml"
                               Write(Html.ValidationMessageFor(m => m.Remarks, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    <span class=""text-danger"" id=""notErro""></span>
                                </div>
                            </div>
                            <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <button class=""btn btn-success serchgaptop"" id=""btnSave"">Save</button>
                                    <br />
                                    <span class=""text-danger"" id=""mainError""></span>
                                </div>
                            </div>
                        </div>
                            <div class=""row"">
                                <div class=""col-sm-3"">
                                    <span class=""text-danger"">");
#nullable restore
#line 88 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\MoveStock.cshtml"
                                                         Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-body all_card_btn"">
                    <!-- Form controls -->

                    <div class=""col-sm-12"">
                        <div class=""card all_btn_card"" id=""lobicard-custom-control1"" data-sortable=""true"">
                            <div class=""card-body"">
                                <h4>Select Items to be moved</h4><br/>

                                <div class=""row"">
                                    <table id=""daiomndsData"" class=""table table-active table-bordered"">
                                        <thead>
                                            <tr>
                                                <th>
                                                    Model Number
                                                </th>
                                             ");
                WriteLiteral(@"   <th>Image</th>
                                                <th>Warehouse Qty</th>
                                                <th>Showroom Qty</th>
                                                <th>Moving Qty</th>
                                                <th></th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>
                                                    ");
#nullable restore
#line 119 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\MoveStock.cshtml"
                                               Write(Html.DropDownListFor(x => Model.InventoryId1, new SelectList(Model.modelDrop, "InventoryId", "ModelNumber", Model.InventoryId1), htmlAttributes: new { id = "invId", @class = "form-control select2", @onchange = "GetBasicInfo()" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                    <span id=""InvError"" class=""text-danger""></span>
                                                </td>
                                                <td>
                                                    <img src=""#"" id=""productImage"" width=""100px;"" />
                                                </td>
                                                <td>
                                                    <span id=""wqty""></span>
                                                </td>
                                                <td>
                                                    <span id=""sqty""></span>
                                                </td>
                                                <td>
                                                    ");
#nullable restore
#line 132 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\MoveStock.cshtml"
                                               Write(Html.TextBoxFor(a => a.Qty1, null, new { @placeholder = "Enter Qty", @id = "qtymoving", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                    <span id=""QtyError"" class=""text-danger""></span>
                                                </td>
                                                <td>
                                                    <input type=""button"" id=""btnAdd"" value=""Add"" class=""btn btn-primary"" />
                                                    <input type=""hidden"" id=""tempImageUrl"" />
                                                </td>
                                            </tr>

                                        </tbody>
                                    </table>
                                    <div class=""card-body"">
                                        <h4>Selected Items information</h4><br/>
                                        <table id=""addedDaimnondData"" class=""table table-avatar table-bordered table-responsive-lg"">
                                            <thead>
                                                <tr>
    ");
                WriteLiteral(@"                                                <th>
                                                        Model Number
                                                    </th>
                                                    <th>Image</th>
                                                    <th>Warehouse Qty</th>
                                                    <th>Showroom Qty</th>
                                                    <th>Moving Qty</th>
                                                    <th>Actions</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                            </tbody>
                                        </table>
                                    </div>
                                    
                                </div>
                            </div>
                            <!-- /.content -->
       ");
                WriteLiteral("                 </div>\r\n                    </div>\r\n\r\n\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
<script>
    /* $('.select2').select2();*/
    $(document).ready(function () {
        CheckStandBY();
    });
    var itemsAdded = 0;
    $(""body"").on(""click"", ""#btnAdd"", function () {
        var inventoryid = $('#invId option:selected').val();
        var modelNumber = $('#invId option:selected').text();
        var wqty = $('#wqty').html();
        var sqty = $('#sqty').html();
        var qty = $('#qtymoving').val();
        var imgurl = $('#tempImageUrl').val();
        if (inventoryid == ""0"") {
            $('#InvError').html('Select Modal');
            return false;
        }
        else {
            $('#InvError').html('');
        }
        if (qty === """") {
            $('#QtyError').html('Enter quantity');
            return false;
        }
        if (qty == ""0"" || parseInt(qty) < 1) {
            $('#QtyError').html('Enter quantity');
            return false;
        }
        if ($('#movedFromD').val() == ""Wareho");
            WriteLiteral(@"use"") {
            if (parseInt(qty) > parseInt(wqty)) {
                $('#QtyError').html('Quantity Exceeding the limit');
                return false;
            }
        }
        if ($('#movedFromD').val() == ""Showroom"") {
            if (parseInt(qty) > parseInt(sqty)) {
                $('#QtyError').html('Quantity Exceeding the limit');
                return false;
            }
        }


        var str = ""<tr><td>"" + modelNumber + "" <input type='hidden' name='InventoryId[]' value='"" + inventoryid + ""'/></td>"";
        str += ""<td> <img src='"" + imgurl + ""' width='100px:' /></td>"";
        str += ""<td>"" + wqty + "" <input type='hidden' name='wQty[]' value='"" + wqty + ""'/></td>"";
        str += ""<td>"" + sqty + "" <input type='hidden' name='sQty[]' value='"" + sqty + ""'/></td>"";
            str += ""<td>"" + qty + "" <input type='hidden' name='Qty[]' value='"" + qty + ""'/></td>"";
            str += ""<td><input type='button' value='Remove' onclick='Remove(this)'<td/></tr>"";
        ");
            WriteLiteral(@"$('#addedDaimnondData').append(str);
        $('#QtyError').html('');

        itemsAdded += 1;


    });

    function Remove(button) {
        var row = $(button).closest(""TR"");
        var name = $(""TD"", row).eq(0).html();
        if (confirm(""Do you want to delete: "")) {
            var table = $(""#addedDaimnondData"")[0];
            table.deleteRow(row[0].rowIndex);
            itemsAdded -= 1;
        }
    };


    function GetBasicInfo() {
        var inventoryid = $('#invId option:selected').val();
        $.ajax({
            url: GlobalUrl + ""Inventory/GetInvBasicInfo?id="" + inventoryid,
            type: 'post',
            data: '{}',
            success: function (res) {
                var r = res.result;
                if (r != null) {
                    $('#sqty').html(r.showroomQty);
                    $('#wqty').html(r.warehouseQty);
                    $('#productImage').attr('src', '../ProductImages/' + r.productImage);
                    $('#tempImageUr");
            WriteLiteral(@"l').val(""../ProductImages/"" + r.productImage);
                    $('#qtymoving').val(0);
                }
            }
        });
    }

    $('#frmStock').submit(function (e) {
        var allOk = true;
        var eq = $('#MoStNot').val();
        e.preventDefault;
        if ($('#movedFromD option:selected').val() == $('#movedToD option:selected').val()) {
            $('#mainError').html('Select different Sources');
            allOk = false;
        }
        else {

        }

        if (itemsAdded == 0) {
            $('#mainError').html('Add items');
            allOk = false;
        }
        else {

        }
        if ($('#MoStNot').val() == null || $('#MoStNot').val()=="""") {
            $('#notErro').html('Please Enter Note');
            allOk = false;
        }
        if (allOk == false) {
            return false;
        }
    });
    function CheckStandBY() {
        var to = $('#movedToD option:selected').val();
        if (to == ""StandBY"") {
   ");
            WriteLiteral("         $(\"#CustOptin\").show();\r\n        }\r\n        else {\r\n            $(\"#CustOptin\").hide();\r\n        }\r\n    }\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SCASA.Models.ModelClasses.StockMovementMasterModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
