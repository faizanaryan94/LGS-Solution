#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using LGS;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Register.cshtml")]
    public partial class _Views_Account_Register_cshtml : System.Web.Mvc.WebViewPage<LGS.Models.RegisterViewModel>
    {
        public _Views_Account_Register_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Account\Register.cshtml"
  
    Layout = "../Shared/_LayoutAccount.cshtml";
    ViewBag.Title = "Register - LGS";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"register-box\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"register-logo\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" href=\"/Home\"");

WriteLiteral("><b>LGS</b>LTE</a>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"register-box-body\"");

WriteLiteral(">\r\n        <p");

WriteLiteral(" class=\"login-box-msg\"");

WriteLiteral(">Register a new membership</p>\r\n");

            
            #line 14 "..\..\Views\Account\Register.cshtml"
        
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Account\Register.cshtml"
         using (Html.BeginForm("Register", "Account", FormMethod.Post))
        {
            
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Account\Register.cshtml"
       Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Account\Register.cshtml"
                                    
            
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Account\Register.cshtml"
       Write(Html.ValidationSummary("", new {@class = "text-danger"}));

            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Account\Register.cshtml"
                                                                     

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group has-feedback\"");

WriteLiteral(">\r\n\r\n");

WriteLiteral("                ");

            
            #line 20 "..\..\Views\Account\Register.cshtml"
           Write(Html.TextBoxFor(m => m.FullName, new {@class = "form-control", @placeholder="Full Name"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"form-group has-feedback\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 23 "..\..\Views\Account\Register.cshtml"
           Write(Html.TextBoxFor(m => m.Email, new {@class = "form-control", @placeholder="Email"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 25 "..\..\Views\Account\Register.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group has-feedback\"");

WriteLiteral(">\r\n\r\n");

WriteLiteral("                ");

            
            #line 28 "..\..\Views\Account\Register.cshtml"
           Write(Html.PasswordFor(m => m.Password, new {@class = "form-control", @placeholder="Password"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 30 "..\..\Views\Account\Register.cshtml"
          

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group has-feedback\"");

WriteLiteral(">\r\n\r\n");

WriteLiteral("                ");

            
            #line 33 "..\..\Views\Account\Register.cshtml"
           Write(Html.PasswordFor(m => m.ConfirmPassword, new {@class = "form-control", @placeholder="Confirm Password"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                ");

WriteLiteral("\r\n                ");

WriteLiteral("\r\n                ");

WriteLiteral("\r\n                ");

WriteLiteral("\r\n                ");

WriteLiteral("\r\n                ");

WriteLiteral("\r\n                ");

WriteLiteral("\r\n                <!-- /.col -->\r\n                <div");

WriteLiteral(" class=\"col-xs-4\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary btn-block btn-flat\"");

WriteLiteral(">Sign In</button>\r\n                </div>\r\n                <!-- /.col -->\r\n      " +
"      </div>\r\n");

            
            #line 49 "..\..\Views\Account\Register.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("        ");

            
            #line 52 "..\..\Views\Account\Register.cshtml"
   Write(Html.ActionLink("Already have an account!", "Login", "Account", new {@class = "text-center"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <!-- /.form-box -->\r\n</div>\r\n<!-- /.register-box -->");

        }
    }
}
#pragma warning restore 1591
