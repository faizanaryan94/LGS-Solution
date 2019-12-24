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
    
    #line 1 "..\..\Views\Admin\Index.cshtml"
    using LGS.Models.RoleNames;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Admin/Index.cshtml")]
    public partial class _Views_Admin_Index_cshtml : System.Web.Mvc.WebViewPage<LGS.Models.ViewModels.DashboardViewModels.DashboardViewModel>
    {
        public _Views_Admin_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Admin\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<section");

WriteLiteral(" class=\"content-header\"");

WriteLiteral(">\r\n    <h1>\r\n        Admin Dashboard\r\n        <small>LGS Control Panel</small>\r\n " +
"   </h1>\r\n    <ol");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n        <li>\r\n            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-dashboard\"");

WriteLiteral("></i> Level</a>\r\n        </li>\r\n        <li");

WriteLiteral(" class=\"active\"");

WriteLiteral(">Admin Dashboard</li>\r\n    </ol>\r\n</section>\r\n<hr/>\r\n<hr/>\r\n\r\n<div");

WriteLiteral(" class=\"col-lg-3 col-xs-6\"");

WriteLiteral(">\r\n    <!-- small box -->\r\n    <div");

WriteLiteral(" class=\"small-box bg-blue\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <h3>");

            
            #line 27 "..\..\Views\Admin\Index.cshtml"
           Write(Model.RegisteredClients);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n            <p>Clients</p>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"icon\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"ion ion-person-add\"");

WriteLiteral("></i>\r\n        </div>\r\n        <a");

WriteLiteral(" href=\"/admin/clientindex\"");

WriteLiteral(" class=\"small-box-footer\"");

WriteLiteral(">More info <i");

WriteLiteral(" class=\"fa fa-arrow-circle-right\"");

WriteLiteral("></i></a>\r\n    </div>\r\n</div>\r\n\r\n");

            
            #line 37 "..\..\Views\Admin\Index.cshtml"
 if (@User.IsInRole(RoleName.Admin))
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"col-lg-3 col-xs-6\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"small-box bg-red\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n                <h3>");

            
            #line 42 "..\..\Views\Admin\Index.cshtml"
               Write(Model.RegisteredSubAdmins);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                <p>Sub-Admins</p>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"icon\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"ion ion-person-add\"");

WriteLiteral("></i>\r\n            </div>\r\n            <a");

WriteLiteral(" href=\"/admin/subadminindex\"");

WriteLiteral(" class=\"small-box-footer\"");

WriteLiteral(">More info <i");

WriteLiteral(" class=\"fa fa-arrow-circle-right\"");

WriteLiteral("></i></a>\r\n        </div>\r\n    </div>\r\n");

            
            #line 51 "..\..\Views\Admin\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"col-lg-3 col-xs-6\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"small-box bg-yellow\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <h3> ");

            
            #line 56 "..\..\Views\Admin\Index.cshtml"
            Write(Model.UniqueUsers);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n            <p>Unique Visitors</p>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"icon\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"ion ion-person-add\"");

WriteLiteral("></i>\r\n        </div>\r\n        ");

WriteLiteral("\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
