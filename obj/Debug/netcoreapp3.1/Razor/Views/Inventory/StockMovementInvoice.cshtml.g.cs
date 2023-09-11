#pragma checksum "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "846e5bc6d417c6b58f7ace3e55385e8e97c3a918"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventory_StockMovementInvoice), @"mvc.1.0.view", @"/Views/Inventory/StockMovementInvoice.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"846e5bc6d417c6b58f7ace3e55385e8e97c3a918", @"/Views/Inventory/StockMovementInvoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f59c02fdbf6895e021479e28253e13dd514c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory_StockMovementInvoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SCASA.Models.ModelClasses.StockMovementForPrint>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
      
    System.Globalization.CultureInfo Indian = new System.Globalization.CultureInfo("hi-IN");
    string totalValue = String.Format(Indian, "{0:N}", Model.TotalValue);
    int rCnt = 1;
    var dt = DateTime.Now;
    var sty = 0;
    var ety = 0;
    if (dt.Month <= 3)
    {
        sty = dt.Year - 1;
        ety = dt.Year;
    }
    else
    {
        sty = dt.Year;
        ety = dt.Year + 1;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""header-icon"">
            <i class=""fa fa-dashboard""></i>
        </div>
        <div class=""header-title"">
            <h1>Stock Movement Invoice</h1>
            <small></small>
        </div>
    </section>
    <!-- Main content -->
    <br />
    <section class=""content"">
        <div class=""row"" style=""align-content:center;"">
            <div id=""Print"" class=""order_summery"">
                <style type=""text/css"">

                    table,
                    td,
                    tr {
                        vertical-align: top;
                        border-collapse: collapse;
                    }

                    * {
                        line-height: inherit;
                    }

                    a[x-apple-data-detectors=true] {
                        color: inherit !important;
                        text-decoration: none");
            WriteLiteral(@" !important;
                    }
                </style>
                <div class=""col-lg-12 pinpin"">
                    <div style=""font-family:'Cabin', Arial, 'Helvetica Neue', Helvetica, sans-serif;"">
                        <table width=""800px"" style=""margin: 0 auto; border:2px solid #a3080d;background-color: #fff;"" cellspacing=""0"" cellpadding=""0"">
                            <tbody>
                                <tr>
                                    <td style=""padding: 15px;"">
                                        <table width=""100%;"">
                                            <tbody>
                                                <tr>
                                                    <td style=""text-align: center; font-size: 18px; font-weight: bold;"">Delivery Challan</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
  ");
            WriteLiteral(@"                              </tr>

                                <tr>
                                    <td style=""border: 1px solid #000;"">
                                        <table width=""100%"">
                                            <tr>
                                                <td style=""width:50%; border-right:2px solid #000;"">
                                                    <table style="" width: 100%; font-size: 13px;"">
                                                        <tr style=""border-bottom: 1px solid #000;"">
                                                            <td style=""padding: 10px;"">
                                                                <h4 style=""margin: 0 0 10px 0; "">SCASA ");
#nullable restore
#line 79 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                                                  Write(Model.MovedFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                                                <div>\r\n                                                                    <span>\r\n                                                                        ");
#nullable restore
#line 82 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                   Write(Model.FromAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                    </span>\r\n                                                                </div>\r\n                                                                <div>E-Mail : ");
#nullable restore
#line 85 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                         Write(Model.FromEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Phone : ");
#nullable restore
#line 85 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                                                   Write(Model.FromMobile);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style=""padding: 10px;"">
                                                                <h4 style=""margin: 0 0 10px 0;"">SCASA ");
#nullable restore
#line 90 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                                                 Write(Model.MovedTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                                                <div>\r\n                                                                    <span>\r\n                                                                        ");
#nullable restore
#line 93 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                   Write(Model.ToAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                </span>\r\n                                                            </div>\r\n                                                            <div>E-Mail : ");
#nullable restore
#line 96 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                     Write(Model.ToEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Phone : ");
#nullable restore
#line 96 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                                             Write(Model.ToMobile);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td style=""width:50%"">
                                                <table width=""100%"">
                                                    <tr>
                                                        <td style=""border:1px solid #000; padding: 5px;"">
                                                            <div>
                                                                <p style=""margin: 0; font-size: 13px"">Dispatch Document No.</p>
                                                                <h5 style=""margin: 0"">");
#nullable restore
#line 107 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                                 Write(Model.DespatchDocumnetNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                                            </div>
                                                        </td>
                                                        <td style=""border:1px solid #000; padding: 5px;"">
                                                            <div>
                                                                <p style=""margin: 0; font-size: 13px"">E-Way Bill No.</p>
                                                                <h5 style=""margin: 0"">");
#nullable restore
#line 113 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                                 Write(Model.EWayBillNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style=""border:1px solid #000; padding: 5px;"">
                                                            <div>
                                                                <p style=""margin: 0; font-size: 13px"">Dispatched Through</p>
                                                                <h5 style=""margin: 0"">");
#nullable restore
#line 121 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                                 Write(Model.DespatchThrough);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                                            </div>
                                                        </td>
                                                        <td style=""border:1px solid #000; padding: 5px;"">
                                                            <div>
                                                                <p style=""margin: 0; font-size: 13px"">Dated</p>
");
#nullable restore
#line 127 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                  
                                                                    DateTime co = Convert.ToDateTime(Model.STDate);
                                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <h5 style=\"margin: 0\">");
#nullable restore
#line 130 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                             Write(co.ToString("dd/MMM/yyyy hh:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
</div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style=""border:1px solid #000; padding: 5px;"">
                                                            <div>
                                                                <p style=""margin: 0; font-size: 13px"">References</p>
                                                                <h5 style=""margin: 0"">");
#nullable restore
#line 138 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                                 Write(Model.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                                            </div>
                                                        </td>
                                                        <td style=""border:1px solid #000; padding: 5px;"">
                                                            <div>
                                                                <p style=""margin: 0; font-size: 13px""></p>
                                                                <h5 style=""margin: 0""></h5>
                                                            </div>
                                                        </td>
                                                    </tr>

                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>

                            <tr>
       ");
            WriteLiteral(@"                         <td>
                            <tr>
                                <td style=""font-size: 13px;"">
                                    <table style=""border:1px solid black;border-collapse:collapse"" width=""100%"">
                                        <thead>
                                            <tr style=""background-color: #dcdcdc; color:#000; font-size: 13px;"">
                                                <th style=""padding:5px;border:1px solid black"">S.No</th>
                                                <th style=""padding:5px;border:1px solid black"">Model Number</th>
                                                <th style=""padding:5px;border:1px solid black"">Image</th>
                                                <th style=""padding:5px;border:1px solid black"">Description</th>
                                                <th style=""padding:5px;border:1px solid black"">Quantity</th>
                                                <th style=""padding:5p");
            WriteLiteral(@"x;border:1px solid black"">Actual Price</th>
                                                <th style=""padding:5px;border:1px solid black"">per</th>
                                                <th style=""padding:5px;border:1px solid black"">Amount</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 174 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                             foreach (var v in Model.stockMaster.items)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td style=\"padding:5px;text-align:center;background:rgba(210, 210, 210, 0.18);border:1px solid #000;\">");
#nullable restore
#line 177 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                                                                                                      Write(rCnt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td style=\"padding:5px;text-align:center;background:rgba(210, 210, 210, 0.18); border:1px solid #000;\">");
#nullable restore
#line 178 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                                                                                                      Write(v.ModelNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 179 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                      
                                                        var proImg = v.ProductImage.Split(",");
                                                     

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td style=\"padding:5px;text-align:center;background:rgba(210, 210, 210, 0.18); border:1px solid #000;\"><img");
            BeginWriteAttribute("src", " src=\"", 11576, "\"", 11609, 2);
            WriteAttributeValue("", 11582, "../ProductImages/", 11582, 17, true);
#nullable restore
#line 182 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
WriteAttributeValue("", 11599, proImg[0], 11599, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100px;\" /></td>\r\n                                                    <td style=\"padding:5px;text-align:center;background:rgba(210, 210, 210, 0.18);border:1px solid #000;\">");
#nullable restore
#line 183 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                                                                                                     Write(v.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td style=\"padding:5px;text-align:center;background:rgba(210, 210, 210, 0.18); border:1px solid #000;\">");
#nullable restore
#line 184 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                                                                                                      Write(v.Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td style=\"padding:5px;text-align:center;background:rgba(210, 210, 210, 0.18); border:1px solid #000;\">");
#nullable restore
#line 185 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                                                                                                      Write(String.Format(Indian, "{0:N}", v.ItemPrice  ));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                                    <td style=""padding:5px;text-align:center;background:rgba(210, 210, 210, 0.18); border:1px solid #000;"">Nos</td>
                                                    <td style=""padding:5px;text-align:right;background:rgba(210, 210, 210, 0.18); border:1px solid #000; font-weight: bold"">");
#nullable restore
#line 187 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                                                                                                                       Write(String.Format(Indian, "{0:N}", v.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                                </tr>\r\n");
#nullable restore
#line 190 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            <tr>
                                                <td style=""padding:5px;text-align:right;background:rgba(210, 210, 210, 0.18);border:1px dashed black"" colspan=""7""> Total</td>
                                                <td style=""padding:5px;text-align:right;background:rgba(210, 210, 210, 0.18);border:1px dashed black; font-weight: bold;"">Rs ");
#nullable restore
#line 194 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                                                                                                                        Write(totalValue);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                            

                            <tr>
                                <td style=""padding: 10px;"">
                                    <div>
                                        <p style=""margin: 0"">Goods Value(In words)</p>
                                        <h4 style=""margin: 0"">INR ");
#nullable restore
#line 206 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                             Write(Model.AmountInWords);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n");
            WriteLiteral(@"                                </td>
                            </tr>

                            <tr>
                                <td style=""padding: 10px;"">
                                    <p>
                                        Total Amount (In words) : <strong>
                                            INR ");
#nullable restore
#line 250 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                           Write(Model.AmountInWords);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </strong>
                                    </p>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <table style=""width: 100%;  font-size: 13px;"">
                                        <tr>
                                            <td style=""width:45%; padding: 10px;"">
                                                <div><span style=""width: 40%"">Company’s PAN</span> : <strong>AJKPM8342C</strong></div>
                                            </td>
                                            <td style=""padding: 10px;"">
");
            WriteLiteral(@"                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <table style=""width:100%;"">
                                        <tr>
                                            <td style=""width: 45%; padding: 10px;"">
                                                <h5 style=""margin: 0"">Declaration</h5>
                                                <div style=""font-size: 12px"">
                                                    We declare that this invoice shows the actual price
                                                    of the goods described and that all particulars are
                                                    true and correct.
                                                </div>
                                ");
            WriteLiteral(@"            </td>
                                            <td style=""border:1px solid #000"">
                                                <table style=""width: 100%"">
                                                    <tr>
                                                        <td style=""text-align: right"">for SCASA-(");
#nullable restore
#line 304 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                                            Write(sty);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 304 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StockMovementInvoice.cshtml"
                                                                                                   Write(ety);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</td>
                                                    </tr>
                                                    <tr>
                                                        <td>&nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td>&nbsp;</td>
                                                    </tr>
                                                    <tr style=""text-align: right"">
                                                        <td>Authorised Signatory</td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </tbody>
                    </table>
       ");
            WriteLiteral(@"         </div>
            </div>
        </div>
    </div>
    <br />
    <div class=""row"">
        <div class=""col-lg-12 pinpin"">
            <div style=""font-family:'Cabin', Arial, 'Helvetica Neue', Helvetica, sans-serif;"">
                <a href=""#"" class=""btn btn-success"" onclick='printDiv();'>Print</a>
            </div>
        </div>
    </div>

</section>
<!-- /.content -->
</div>
<script>
    function printDiv() {

        var divContents = $("".order_summery"").html();//div which have to print
        var printWindow = window.open('', '', 'height=700,width=900');
        printWindow.document.write('<html><head><title></title>');
        printWindow.document.write('<link rel=""stylesheet"" href=""//netdna.bootstrapcdn.com/bootstrap/3.1.0/css/bootstrap.min.css"" >');//external styles
        printWindow.document.write('<link rel=""stylesheet"" href=""/css/custom.css"" type=""text/css""/>');
        printWindow.document.write('</head><body>');
        printWindow.document.write(divConte");
            WriteLiteral(@"nts);
        printWindow.document.write('</body></html>');
        printWindow.document.close();

        printWindow.onload = function () {
            printWindow.focus();
            printWindow.print();
            printWindow.close();
        };

        //var divToPrint = document.getElementById('Print');

        //var newWin = window.open('', 'Print-Window');

        //newWin.document.open();

        //newWin.document.write('<html><body onload=""window.print()"">' + divToPrint.innerHTML + '</body></html>');

        //newWin.document.close();

        //setTimeout(function () { newWin.close(); }, 10);

    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SCASA.Models.ModelClasses.StockMovementForPrint> Html { get; private set; }
    }
}
#pragma warning restore 1591
