#pragma checksum "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2786d964a28359e7ba266627077e3f14a046d730"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cashiers_CashiersEdit), @"mvc.1.0.view", @"/Views/Cashiers/CashiersEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2786d964a28359e7ba266627077e3f14a046d730", @"/Views/Cashiers/CashiersEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76f1f67170b90bdbe923fb31d49d76e3ccc5bc02", @"/Views/_ViewImports.cshtml")]
    public class Views_Cashiers_CashiersEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TicketingSystem.Web.Models.Cashier>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>CashierEdit</h2>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersEdit.cshtml"
 using (Html.BeginForm("Edit", "Cashiers"))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersEdit.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersEdit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersEdit.cshtml"
Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersEdit.cshtml"
Write(Html.Hidden("editAction", ViewData["editAction"].ToString()));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersEdit.cshtml"
                                                                 ;


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"editor-label\">");
#nullable restore
#line 15 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersEdit.cshtml"
                         Write(Html.LabelFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"editor-field\">");
#nullable restore
#line 16 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersEdit.cshtml"
                         Write(Html.EditorFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            WriteLiteral("    <div class=\"editor-label\">");
#nullable restore
#line 18 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersEdit.cshtml"
                         Write(Html.LabelFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"editor-field\">");
#nullable restore
#line 19 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersEdit.cshtml"
                         Write(Html.EditorFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            WriteLiteral("    <div class=\"editor-label\">");
#nullable restore
#line 21 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersEdit.cshtml"
                         Write(Html.LabelFor(m => m.BankAccount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"editor-field\">");
#nullable restore
#line 22 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersEdit.cshtml"
                         Write(Html.EditorFor(m => m.BankAccount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            WriteLiteral("    <div class=\"editor-label\">");
#nullable restore
#line 24 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersEdit.cshtml"
                         Write(Html.LabelFor(m => m.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"editor-field\">");
#nullable restore
#line 25 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersEdit.cshtml"
                         Write(Html.EditorFor(m => m.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            WriteLiteral("    <div class=\"editor-label\">");
#nullable restore
#line 27 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersEdit.cshtml"
                         Write(Html.LabelFor(m => m.Insurance));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"editor-field\">");
#nullable restore
#line 28 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersEdit.cshtml"
                         Write(Html.EditorFor(m => m.Insurance));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"SEND\"/>\r\n");
#nullable restore
#line 31 "C:\Users\User\OneDrive - Óbudai egyetem\Documents\oenik_prog4hf_2021_1_f8skrv\TicketingSystem\TicketingSystem.Web\Views\Cashiers\CashiersEdit.cshtml"
}

#line default
#line hidden
#nullable disable
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
