#pragma checksum "C:\Users\Anonymous\source\repos\TheGymWebsite\TheGymWebsite\Views\Member\MemberDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95d18ad9f4d038bfc595bc4ed010ead8bf6e8c40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_MemberDetails), @"mvc.1.0.view", @"/Views/Member/MemberDetails.cshtml")]
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
#line 1 "C:\Users\Anonymous\source\repos\TheGymWebsite\TheGymWebsite\Views\_ViewImports.cshtml"
using TheGymWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anonymous\source\repos\TheGymWebsite\TheGymWebsite\Views\_ViewImports.cshtml"
using TheGymWebsite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anonymous\source\repos\TheGymWebsite\TheGymWebsite\Views\_ViewImports.cshtml"
using TheGymWebsite.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Anonymous\source\repos\TheGymWebsite\TheGymWebsite\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95d18ad9f4d038bfc595bc4ed010ead8bf6e8c40", @"/Views/Member/MemberDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0ddffdaeb138b1e66988ddb2c1408187481bd75", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_MemberDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUserDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning m-1 ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUserPassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Anonymous\source\repos\TheGymWebsite\TheGymWebsite\Views\Member\MemberDetails.cshtml"
  
    ViewData["Title"] = "Member Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid gym-background min-vh-100"">
    <div class=""p-3 p-sm-5 offset-md-1"">
        <div class=""row"">
            <div class=""col-12 col-md-6"">
                <h3 class=""font-weight-bold pb-3"">Account details</h3>
                <dl>
                    <dt>Name:</dt>
                    <dd>");
#nullable restore
#line 15 "C:\Users\Anonymous\source\repos\TheGymWebsite\TheGymWebsite\Views\Member\MemberDetails.cshtml"
                   Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "C:\Users\Anonymous\source\repos\TheGymWebsite\TheGymWebsite\Views\Member\MemberDetails.cshtml"
                                    Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                    <dt>Date Of Birth:</dt>\r\n                    <dd>");
#nullable restore
#line 17 "C:\Users\Anonymous\source\repos\TheGymWebsite\TheGymWebsite\Views\Member\MemberDetails.cshtml"
                   Write(Model.DateOfBirth.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                    <dt>Gender:</dt>\r\n                    <dd>");
#nullable restore
#line 19 "C:\Users\Anonymous\source\repos\TheGymWebsite\TheGymWebsite\Views\Member\MemberDetails.cshtml"
                   Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                </dl>\r\n            </div>\r\n            <div class=\"col-12 col-md-6\">\r\n                <h3 class=\"font-weight-bold pb-3\">Contact details</h3>\r\n                <dl>\r\n                    <dt>Email:</dt>\r\n                    <dd>");
#nullable restore
#line 26 "C:\Users\Anonymous\source\repos\TheGymWebsite\TheGymWebsite\Views\Member\MemberDetails.cshtml"
                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                    <dt>Phone number:</dt>\r\n                    <dd>");
#nullable restore
#line 28 "C:\Users\Anonymous\source\repos\TheGymWebsite\TheGymWebsite\Views\Member\MemberDetails.cshtml"
                   Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                    <dt>Address:</dt>\r\n                    <dd>");
#nullable restore
#line 30 "C:\Users\Anonymous\source\repos\TheGymWebsite\TheGymWebsite\Views\Member\MemberDetails.cshtml"
                   Write(Model.AddressLineOne);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                    <dd>");
#nullable restore
#line 31 "C:\Users\Anonymous\source\repos\TheGymWebsite\TheGymWebsite\Views\Member\MemberDetails.cshtml"
                   Write(Model.AddressLineTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                    <dd>");
#nullable restore
#line 32 "C:\Users\Anonymous\source\repos\TheGymWebsite\TheGymWebsite\Views\Member\MemberDetails.cshtml"
                   Write(Model.Town);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                    <dd>");
#nullable restore
#line 33 "C:\Users\Anonymous\source\repos\TheGymWebsite\TheGymWebsite\Views\Member\MemberDetails.cshtml"
                   Write(Model.Postcode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                </dl>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95d18ad9f4d038bfc595bc4ed010ead8bf6e8c408792", async() => {
                WriteLiteral("Edit your details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-email", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\Anonymous\source\repos\TheGymWebsite\TheGymWebsite\Views\Member\MemberDetails.cshtml"
                                                                          WriteLiteral(Model.Email);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-email", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95d18ad9f4d038bfc595bc4ed010ead8bf6e8c4011367", async() => {
                WriteLiteral("Change your password");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-email", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\Anonymous\source\repos\TheGymWebsite\TheGymWebsite\Views\Member\MemberDetails.cshtml"
                                                                           WriteLiteral(Model.Email);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-email", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <div>\r\n\r\n        </div>\r\n        <br />\r\n        <br />\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
