#pragma checksum "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2eb9c0e09aa278b50f65060a3da96f5f1cddedb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cashiers_CashiersDetails), @"mvc.1.0.view", @"/Views/Cashiers/CashiersDetails.cshtml")]
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
#line 1 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\_ViewImports.cshtml"
using TicketingSystem.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\_ViewImports.cshtml"
using TicketingSystem.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2eb9c0e09aa278b50f65060a3da96f5f1cddedb7", @"/Views/Cashiers/CashiersDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76f1f67170b90bdbe923fb31d49d76e3ccc5bc02", @"/Views/_ViewImports.cshtml")]
    public class Views_Cashiers_CashiersDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TicketingSystem.Web.Models.Cashier>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersDetails.cshtml"
  
    ViewData["Title"] = "CashiersDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Datasheet of one cashier</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersDetails.cshtml"
Write(Html.ActionLink("Back to the list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n<table border=\"1\">\r\n    <tr>\r\n        <td>");
#nullable restore
#line 13 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersDetails.cshtml"
       Write(Html.DisplayNameFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 14 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersDetails.cshtml"
       Write(Html.DisplayFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 17 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersDetails.cshtml"
       Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 18 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersDetails.cshtml"
       Write(Html.DisplayFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 21 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersDetails.cshtml"
       Write(Html.DisplayNameFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 22 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersDetails.cshtml"
       Write(Html.DisplayFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 25 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersDetails.cshtml"
       Write(Html.DisplayNameFor(m => m.BankAccount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 26 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersDetails.cshtml"
       Write(Html.DisplayFor(m => m.BankAccount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 29 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersDetails.cshtml"
       Write(Html.DisplayNameFor(m => m.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 30 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersDetails.cshtml"
       Write(Html.DisplayFor(m => m.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 33 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersDetails.cshtml"
       Write(Html.DisplayNameFor(m => m.Insurance));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 34 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersDetails.cshtml"
       Write(Html.DisplayFor(m => m.Insurance));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TicketingSystem.Web.Models.Cashier> Html { get; private set; }
    }
}
#pragma warning restore 1591