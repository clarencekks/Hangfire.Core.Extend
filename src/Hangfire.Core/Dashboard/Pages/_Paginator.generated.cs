﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.Dashboard.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\Dashboard\Pages\_Paginator.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class _Paginator : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");



WriteLiteral("<div class=\"btn-toolbar\">\r\n");


            
            #line 5 "..\..\Dashboard\Pages\_Paginator.cshtml"
     if (_pager.TotalPageCount > 1)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div class=\"btn-group paginator\">\r\n");


            
            #line 8 "..\..\Dashboard\Pages\_Paginator.cshtml"
             foreach (var page in _pager.PagerItems)
            {
                switch (page.Type)
                {
                    case Pager.ItemType.Page:

            
            #line default
            #line hidden
WriteLiteral("                        <a href=\"");


            
            #line 13 "..\..\Dashboard\Pages\_Paginator.cshtml"
                            Write(_pager.PageUrl(page.PageIndex));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"btn btn-default ");


            
            #line 13 "..\..\Dashboard\Pages\_Paginator.cshtml"
                                                                                     Write(_pager.CurrentPage == page.PageIndex ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            ");


            
            #line 14 "..\..\Dashboard\Pages\_Paginator.cshtml"
                       Write(page.PageIndex);

            
            #line default
            #line hidden
WriteLiteral("  \r\n                        </a>\r\n");


            
            #line 16 "..\..\Dashboard\Pages\_Paginator.cshtml"
                        break;
                    case Pager.ItemType.NextPage:

            
            #line default
            #line hidden
WriteLiteral("                        <a href=\"");


            
            #line 18 "..\..\Dashboard\Pages\_Paginator.cshtml"
                            Write(_pager.PageUrl(page.PageIndex));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"btn btn-default ");


            
            #line 18 "..\..\Dashboard\Pages\_Paginator.cshtml"
                                                                                     Write(page.Disabled ? "disabled" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            Next\r\n                        </a>\r\n");


            
            #line 21 "..\..\Dashboard\Pages\_Paginator.cshtml"
                        break;
                    case Pager.ItemType.PrevPage:

            
            #line default
            #line hidden
WriteLiteral("                        <a href=\"");


            
            #line 23 "..\..\Dashboard\Pages\_Paginator.cshtml"
                            Write(_pager.PageUrl(page.PageIndex));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"btn btn-default ");


            
            #line 23 "..\..\Dashboard\Pages\_Paginator.cshtml"
                                                                                     Write(page.Disabled ? "disabled" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            Prev\r\n                        </a>\r\n");


            
            #line 26 "..\..\Dashboard\Pages\_Paginator.cshtml"
                        break;
                    case Pager.ItemType.MorePage:

            
            #line default
            #line hidden
WriteLiteral("                        <a href=\"#\" class=\"btn btn-default disabled\">\r\n          " +
"                  …\r\n                        </a>\r\n");


            
            #line 31 "..\..\Dashboard\Pages\_Paginator.cshtml"
                        break;
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n");



WriteLiteral("        <div class=\"btn-toolbar-spacer\"></div>\r\n");


            
            #line 36 "..\..\Dashboard\Pages\_Paginator.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div class=\"btn-toolbar-label\">Total items: ");


            
            #line 38 "..\..\Dashboard\Pages\_Paginator.cshtml"
                                           Write(_pager.TotalRecordCount);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n</div>\r\n");


        }
    }
}
#pragma warning restore 1591
