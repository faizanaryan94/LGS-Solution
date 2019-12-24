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
    
    #line 1 "..\..\Views\Account\Login.cshtml"
    using LGS.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Login.cshtml")]
    public partial class _Views_Account_Login_cshtml : System.Web.Mvc.WebViewPage<LoginViewModel>
    {
        public _Views_Account_Login_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Account\Login.cshtml"
  
    Layout = "../Shared/_LayoutAccount.cshtml";
    ViewBag.Title = "Login - LGS";

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"hold-transition login-page\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"login-box\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"login-logo\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" href=\"../../index2.html\"");

WriteLiteral(">\r\n                <b>LGS</b>LTE\r\n            </a>\r\n        </div>\r\n        <!-- " +
"/.login-logo -->\r\n        <div");

WriteLiteral(" class=\"login-box-body\"");

WriteLiteral(">\r\n            <p");

WriteLiteral(" class=\"login-box-msg\"");

WriteLiteral(">Sign in to start your session</p>\r\n");

            
            #line 17 "..\..\Views\Account\Login.cshtml"
            
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Account\Login.cshtml"
             using (Html.BeginForm("Login", "Account", new { ReturnUrl = ViewBag.ReturnUrl }, FormMethod.Post, new { role = "form" }))
            {
                
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Account\Login.cshtml"
           Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Account\Login.cshtml"
                                        
                
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Account\Login.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Account\Login.cshtml"
                                                                                 



            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"form-group has-feedback\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 24 "..\..\Views\Account\Login.cshtml"
               Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control", @placeholder = "Email" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <span");

WriteLiteral(" class=\"glyphicon glyphicon-envelope form-control-feedback\"");

WriteLiteral("></span>\r\n");

WriteLiteral("                    ");

            
            #line 26 "..\..\Views\Account\Login.cshtml"
               Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

            
            #line 28 "..\..\Views\Account\Login.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"form-group has-feedback\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 30 "..\..\Views\Account\Login.cshtml"
               Write(Html.PasswordFor(m => m.Password, new { @class = "form-control", @placeholder = "Password" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <span");

WriteLiteral(" class=\"glyphicon glyphicon-lock form-control-feedback\"");

WriteLiteral("></span>\r\n");

WriteLiteral("                    ");

            
            #line 32 "..\..\Views\Account\Login.cshtml"
               Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-xs-8\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"checkbox icheck\"");

WriteLiteral(">\r\n                            <label>\r\n");

WriteLiteral("                                ");

            
            #line 38 "..\..\Views\Account\Login.cshtml"
                           Write(Html.CheckBoxFor(m => m.RememberMe));

            
            #line default
            #line hidden
WriteLiteral(" Remember Me\r\n                            </label>\r\n                        </div" +
">\r\n                    </div>\r\n                    <!-- /.col -->\r\n             " +
"       <div");

WriteLiteral(" class=\"col-xs-4\"");

WriteLiteral(">\r\n                        <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary btn-block btn-flat\"");

WriteLiteral(">Sign In</button>\r\n                    </div>\r\n                    <!-- /.col -->" +
"\r\n                </div>\r\n");

            
            #line 48 "..\..\Views\Account\Login.cshtml"

                
            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Account\Login.cshtml"
           Write(Html.ActionLink("Forgot your password?", "ForgotPassword"));

            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Account\Login.cshtml"
                                                                           

            
            #line default
            #line hidden
WriteLiteral("                <br>\r\n");

            
            #line 51 "..\..\Views\Account\Login.cshtml"
                
            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Account\Login.cshtml"
                                                                                                            

                
            
            #line default
            #line hidden
            
            #line 53 "..\..\Views\Account\Login.cshtml"
           Write(Html.ActionLink("Register as a new user", "Register", "", new { @class = "text-center" }));

            
            #line default
            #line hidden
            
            #line 53 "..\..\Views\Account\Login.cshtml"
                                                                                                          


            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n        ");

WriteLiteral("\r\n        ");

WriteLiteral("\r\n        ");

WriteLiteral("\r\n        ");

WriteLiteral("\r\n        ");

WriteLiteral("\r\n    </div>\r\n\r\n\r\n\r\n    <!-- /.login-box-body -->\r\n    <!-- /.login-box -->\r\n\r\n  " +
" \r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
