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
    
    #line 2 "..\..\Views\Manage\ManageLogins.cshtml"
    using Microsoft.Owin.Security;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Manage/ManageLogins.cshtml")]
    public partial class _Views_Manage_ManageLogins_cshtml : System.Web.Mvc.WebViewPage<LGS.Models.ManageLoginsViewModel>
    {
        public _Views_Manage_ManageLogins_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Manage\ManageLogins.cshtml"
  
    ViewBag.Title = "Manage your external logins";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>");

            
            #line 7 "..\..\Views\Manage\ManageLogins.cshtml"
Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(".</h2>\r\n\r\n<p");

WriteLiteral(" class=\"text-success\"");

WriteLiteral(">");

            
            #line 9 "..\..\Views\Manage\ManageLogins.cshtml"
                   Write(ViewBag.StatusMessage);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 10 "..\..\Views\Manage\ManageLogins.cshtml"
  
    var loginProviders = Context.GetOwinContext().Authentication.GetExternalAuthenticationTypes();
    if (loginProviders.Count() == 0) {

            
            #line default
            #line hidden
WriteLiteral("        <div>\r\n            <p>\r\n                There are no external authenticat" +
"ion services configured. See <a");

WriteLiteral(" href=\"https://go.microsoft.com/fwlink/?LinkId=313242\"");

WriteLiteral(">this article</a>\r\n                for details on setting up this ASP.NET applica" +
"tion to support logging in via external services.\r\n            </p>\r\n        </d" +
"iv>\r\n");

            
            #line 19 "..\..\Views\Manage\ManageLogins.cshtml"
    }
    else
    {
        if (Model.CurrentLogins.Count > 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <h4>Registered Logins</h4>\r\n");

WriteLiteral("            <table");

WriteLiteral(" class=\"table\"");

WriteLiteral(">\r\n                <tbody>\r\n");

            
            #line 27 "..\..\Views\Manage\ManageLogins.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\Manage\ManageLogins.cshtml"
                     foreach (var account in Model.CurrentLogins)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <tr>\r\n                            <td>");

            
            #line 30 "..\..\Views\Manage\ManageLogins.cshtml"
                           Write(account.LoginProvider);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td>\r\n");

            
            #line 32 "..\..\Views\Manage\ManageLogins.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\Manage\ManageLogins.cshtml"
                                 if (ViewBag.ShowRemoveButton)
                                {
                                    using (Html.BeginForm("RemoveLogin", "Manage"))
                                    {
                                        
            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Manage\ManageLogins.cshtml"
                                   Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Manage\ManageLogins.cshtml"
                                                                

            
            #line default
            #line hidden
WriteLiteral("                                        <div>\r\n");

WriteLiteral("                                            ");

            
            #line 38 "..\..\Views\Manage\ManageLogins.cshtml"
                                       Write(Html.Hidden("loginProvider", account.LoginProvider));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                            ");

            
            #line 39 "..\..\Views\Manage\ManageLogins.cshtml"
                                       Write(Html.Hidden("providerKey", account.ProviderKey));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" value=\"Remove\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1715), Tuple.Create("\"", 1781)
, Tuple.Create(Tuple.Create("", 1723), Tuple.Create("Remove", 1723), true)
, Tuple.Create(Tuple.Create(" ", 1729), Tuple.Create("this", 1730), true)
            
            #line 40 "..\..\Views\Manage\ManageLogins.cshtml"
                                          , Tuple.Create(Tuple.Create(" ", 1734), Tuple.Create<System.Object, System.Int32>(account.LoginProvider
            
            #line default
            #line hidden
, 1735), false)
, Tuple.Create(Tuple.Create(" ", 1757), Tuple.Create("login", 1758), true)
, Tuple.Create(Tuple.Create(" ", 1763), Tuple.Create("from", 1764), true)
, Tuple.Create(Tuple.Create(" ", 1768), Tuple.Create("your", 1769), true)
, Tuple.Create(Tuple.Create(" ", 1773), Tuple.Create("account", 1774), true)
);

WriteLiteral(" />\r\n                                        </div>\r\n");

            
            #line 42 "..\..\Views\Manage\ManageLogins.cshtml"
                                    }
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    ");

WriteLiteral(" &nbsp;\r\n");

            
            #line 47 "..\..\Views\Manage\ManageLogins.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </td>\r\n                        </tr>\r\n");

            
            #line 50 "..\..\Views\Manage\ManageLogins.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </tbody>\r\n            </table>\r\n");

            
            #line 53 "..\..\Views\Manage\ManageLogins.cshtml"
        }
        if (Model.OtherLogins.Count > 0)
        {
            using (Html.BeginForm("LinkLogin", "Manage"))
            {
                
            
            #line default
            #line hidden
            
            #line 58 "..\..\Views\Manage\ManageLogins.cshtml"
           Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 58 "..\..\Views\Manage\ManageLogins.cshtml"
                                        

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" id=\"socialLoginList\"");

WriteLiteral(">\r\n                <p>\r\n");

            
            #line 61 "..\..\Views\Manage\ManageLogins.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\Manage\ManageLogins.cshtml"
                     foreach (AuthenticationDescription p in Model.OtherLogins)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteAttribute("id", Tuple.Create(" id=\"", 2619), Tuple.Create("\"", 2645)
            
            #line 63 "..\..\Views\Manage\ManageLogins.cshtml"
, Tuple.Create(Tuple.Create("", 2624), Tuple.Create<System.Object, System.Int32>(p.AuthenticationType
            
            #line default
            #line hidden
, 2624), false)
);

WriteLiteral(" name=\"provider\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2662), Tuple.Create("\"", 2691)
            
            #line 63 "..\..\Views\Manage\ManageLogins.cshtml"
                                        , Tuple.Create(Tuple.Create("", 2670), Tuple.Create<System.Object, System.Int32>(p.AuthenticationType
            
            #line default
            #line hidden
, 2670), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 2692), Tuple.Create("\"", 2736)
, Tuple.Create(Tuple.Create("", 2700), Tuple.Create("Log", 2700), true)
, Tuple.Create(Tuple.Create(" ", 2703), Tuple.Create("in", 2704), true)
, Tuple.Create(Tuple.Create(" ", 2706), Tuple.Create("using", 2707), true)
, Tuple.Create(Tuple.Create(" ", 2712), Tuple.Create("your", 2713), true)
            
            #line 63 "..\..\Views\Manage\ManageLogins.cshtml"
                                                                                       , Tuple.Create(Tuple.Create(" ", 2717), Tuple.Create<System.Object, System.Int32>(p.Caption
            
            #line default
            #line hidden
, 2718), false)
, Tuple.Create(Tuple.Create(" ", 2728), Tuple.Create("account", 2729), true)
);

WriteLiteral(">");

            
            #line 63 "..\..\Views\Manage\ManageLogins.cshtml"
                                                                                                                                                                                       Write(p.AuthenticationType);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");

            
            #line 64 "..\..\Views\Manage\ManageLogins.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </p>\r\n                </div>\r\n");

            
            #line 67 "..\..\Views\Manage\ManageLogins.cshtml"
            }
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
