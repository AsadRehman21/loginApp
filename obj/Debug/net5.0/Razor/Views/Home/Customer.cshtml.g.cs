#pragma checksum "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "050e510622977b1ad6f3180a758666506592a0d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Customer), @"mvc.1.0.view", @"/Views/Home/Customer.cshtml")]
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
#line 1 "/home/asad/Desktop/loginApp/Views/_ViewImports.cshtml"
using loginApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/asad/Desktop/loginApp/Views/_ViewImports.cshtml"
using loginApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"050e510622977b1ad6f3180a758666506592a0d2", @"/Views/Home/Customer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"907ce118f4a3885b8350cb6ebf74ba592ea09de1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Customer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<loginApp.Models.CustomerandOrderList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""content"" >
                     
<table  class=""table table-dark table-hover"">
    <thead  >
        <tr >
          
            <th scope=""col"">Company Name</th>
            <th scope=""col"">Contact Name</th>
            <th scope=""col"">Contact Title</th>
            <th scope=""col"">Address</th>
            <th scope=""col"">City</th>
            <th scope=""col"">Region</th>
            <th scope=""col"">Postal Code</th>
            <th scope=""col"">Country</th>
            <th scope=""col"">Phone</th>
            <th scope=""col"">Fax</th>
            <th scope=""col"">Order Id</th>
             <th scope=""col"">Action</th>
        </tr>
    </thead>
    <tbody >
        
");
#nullable restore
#line 24 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
         foreach (var x in Model.Customers)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
             foreach (var y in @x.Orders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                \n                <td style=\"vertical-align: middle\">");
#nullable restore
#line 30 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
                                              Write(x.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"vertical-align: middle\">");
#nullable restore
#line 31 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
                                              Write(x.ContactName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"vertical-align: middle\">");
#nullable restore
#line 32 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
                                              Write(x.ContactTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"vertical-align: middle\">");
#nullable restore
#line 33 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
                                              Write(x.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"vertical-align: middle\">");
#nullable restore
#line 34 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
                                              Write(x.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"vertical-align: middle\">");
#nullable restore
#line 35 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
                                              Write(x.Region);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"vertical-align: middle\">");
#nullable restore
#line 36 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
                                              Write(x.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"vertical-align: middle\">");
#nullable restore
#line 37 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
                                              Write(x.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"vertical-align: middle\">");
#nullable restore
#line 38 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
                                              Write(x.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"vertical-align: middle\">");
#nullable restore
#line 39 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
                                              Write(x.Fax);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"vertical-align: middle\">");
#nullable restore
#line 40 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
                                              Write(y.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1664, "\"", 1823, 23);
            WriteAttributeValue("", 1674, "edit(\'", 1674, 6, true);
#nullable restore
#line 42 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
WriteAttributeValue("", 1680, x.Id, 1680, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1685, "\',\'", 1685, 3, true);
#nullable restore
#line 42 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
WriteAttributeValue("", 1688, x.CompanyName, 1688, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1702, "\',\'", 1702, 3, true);
#nullable restore
#line 42 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
WriteAttributeValue("", 1705, x.ContactName, 1705, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1719, "\',\'", 1719, 3, true);
#nullable restore
#line 42 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
WriteAttributeValue("", 1722, x.ContactTitle, 1722, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1737, "\',\'", 1737, 3, true);
#nullable restore
#line 42 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
WriteAttributeValue("", 1740, x.Address, 1740, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1750, "\',\'", 1750, 3, true);
#nullable restore
#line 42 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
WriteAttributeValue("", 1753, x.City, 1753, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1760, "\',\'", 1760, 3, true);
#nullable restore
#line 42 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
WriteAttributeValue("", 1763, x.Region, 1763, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1772, "\',\'", 1772, 3, true);
#nullable restore
#line 42 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
WriteAttributeValue("", 1775, x.PostalCode, 1775, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1788, "\',\'", 1788, 3, true);
#nullable restore
#line 42 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
WriteAttributeValue("", 1791, x.Country, 1791, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1801, "\',\'", 1801, 3, true);
#nullable restore
#line 42 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
WriteAttributeValue("", 1804, x.Phone, 1804, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1812, "\',\'", 1812, 3, true);
#nullable restore
#line 42 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
WriteAttributeValue("", 1815, x.Fax, 1815, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1821, "\')", 1821, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info \"><i class=\"fas fa-user-edit\"></i></button>\n                   \n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", "  onclick=\"", 1950, "\"", 2028, 3);
            WriteAttributeValue("", 1961, "location.href=\'", 1961, 15, true);
#nullable restore
#line 44 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
WriteAttributeValue("", 1976, Url.Action("Delete", "Home", new { id1 = @x.Id  }), 1976, 51, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2027, "\'", 2027, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"><i class=\"fas fa-trash\"></i></button>\n                </td>\n            </tr>\n");
#nullable restore
#line 47 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "/home/asad/Desktop/loginApp/Views/Home/Customer.cshtml"
         
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
</div>


                               
                      
<script>
	
	
var edit=function(id,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax)
{
  
  swal.fire({

                html: ' <div class=""form-row""><label style=""float:left;"">Company Name</label><input id=""swal-input1"" class=""swal2-input"" value=""'+CompanyName+'""><label style=""float:left;"">Contact Name</label><input  id=""swal-input2"" class=""swal2-input"" value=""'+ContactName+'""><label style=""float:left;"">Contact Title</label><input  value=""'+ContactTitle+'"" id=""swal-input3"" class=""swal2-input"" ><label style=""float:left;"">Address</label><input id=""swal-input4"" class=""swal2-input"" value=""'+Address+'""><label style=""float:left;"">City</label><input id=""swal-input5"" class=""swal2-input"" value=""'+City+'""><label style=""float:left;"">Region</label><input id=""swal-input6"" class=""swal2-input"" value=""'+Region+'""><label style=""float:left;"" >Postal Code</label><input id=""swal-input7"" class=""swal2-input"" ");
            WriteLiteral(@"value=""'+PostalCode+'""><label style=""float:left;"">Country</label><input id=""swal-input8"" class=""swal2-input"" value=""'+Country+'""><label style=""float:left;"">Phone</label><input id=""swal-input9"" class=""swal2-input"" value=""'+Phone+'""><label style=""float:left;"">Fax</label><input id=""swal-input10"" class=""swal2-input"" value=""'+Fax+'""></div>', 
                width: '600px',
                showCancelButton: true,

                 cancelButtonText: 'Cancel',
                confirmButtonText: ""Save"",
            }).then((result) => {
                if (result.isConfirmed) {
                   var  CompanyName = document.getElementById('swal-input1').value;
                   var ContactName = document.getElementById('swal-input2').value;
                   var ContactTitle = document.getElementById('swal-input3').value;
                   var Address= document.getElementById('swal-input4').value;
                   var City= document.getElementById('swal-input5').value;
                   var Region= document.get");
            WriteLiteral(@"ElementById('swal-input6').value;
                   var PostalCode= document.getElementById('swal-input7').value;
                   var Country= document.getElementById('swal-input8').value;
                   var Phone= document.getElementById('swal-input9').value;
                   var Fax= document.getElementById('swal-input10').value;
                 
            
                   var fd = new FormData();
                   
                   fd.append(""CompanyName"", CompanyName);
                   fd.append(""ContactName"", ContactName);
                   fd.append(""ContactTitle"",ContactTitle );
                   fd.append(""Address"",Address );
                   fd.append(""City"", City);
                   fd.append(""Region"", Region);
                   fd.append(""PostalCode"", PostalCode);
                   fd.append(""Country"",Country );
                   fd.append(""Phone"",Phone );
                   fd.append(""Fax"", Fax);
                   fd.append(""Id"", id);
                    
            ");
            WriteLiteral(@"        $.ajax({
                        type: ""POST"",
                        url: '/Home/Update',
                        data: fd,
                       
                        contentType: false,
                        processData: false,
                        success: function(data) {
                            
                           
                              swal.fire(""Updated!"", ""Data updated successfully!"", ""success"")
                              .then((value) => {
                                 location.reload()
                                  });
                               
                        },

                        error: function(xhr, error, status) {
                            console.log(xhr, error, status);
                        }
                    });

                } else if (
                    /* Read more about handling dismissals below */
                    result.dismiss === Swal.DismissReason.cancel
                ) {
                    swal.");
            WriteLiteral("fire(\n                    \'Cancelled\',\n                    \'Your data file is safe :)\',\n                    \'error\'\n                    )\n                }\n                })\n\n\n          \n}\n\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<loginApp.Models.CustomerandOrderList> Html { get; private set; }
    }
}
#pragma warning restore 1591
