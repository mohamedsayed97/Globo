#pragma checksum "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\Components\Pager.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7af6b00fc090bfbbc9b08f80c25392fa83d9f28f"
// <auto-generated/>
#pragma warning disable 1591
namespace GloboTicket.TicketManagement.App.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using GloboTicket.TicketManagement.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using GloboTicket.TicketManagement.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using GloboTicket.TicketManagement.App.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    public partial class Pager : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\Components\Pager.razor"
 if (TotalPages > 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "float-left pager mt-3");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "type", "button");
            __builder.AddAttribute(6, "class", 
#nullable restore
#line 4 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\Components\Pager.razor"
                                       (PageIndex == 1) ? "pager-btn-disabled" : "pager-btn"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\Components\Pager.razor"
                                                                                                           () => OnClick.InvokeAsync(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(8, "\r\n            <i class=\"fa fa-angle-double-left\" aria-hidden=\"true\"></i>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "type", "button");
            __builder.AddAttribute(12, "class", 
#nullable restore
#line 7 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\Components\Pager.razor"
                                       HasPreviousPage ? "pager-btn" : "pager-btn-disabled"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\Components\Pager.razor"
                                                                                                          () => OnClick.InvokeAsync(PageIndex - 1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, "\r\n            <i class=\"fa fa-angle-left\" aria-hidden=\"true\"></i>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "span");
            __builder.AddContent(17, 
#nullable restore
#line 10 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\Components\Pager.razor"
               PageIndex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "type", "button");
            __builder.AddAttribute(21, "class", 
#nullable restore
#line 11 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\Components\Pager.razor"
                                       HasNextPage ? "pager-btn" : "pager-btn-disabled"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\Components\Pager.razor"
                                                                                                      () => OnClick.InvokeAsync(PageIndex + 1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "\r\n            <i class=\"fa fa-angle-right\" aria-hidden=\"true\"></i>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "type", "button");
            __builder.AddAttribute(27, "class", 
#nullable restore
#line 14 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\Components\Pager.razor"
                                       (PageIndex == TotalPages) ? "pager-btn-disabled" : "pager-btn"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\Components\Pager.razor"
                                                                                                                    () => OnClick.InvokeAsync(TotalPages)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "\r\n            <i class=\"fa fa-angle-double-right\" aria-hidden=\"true\"></i>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 18 "C:\Users\ma7md\OneDrive\Desktop\asp net core architecture assets\09\demos\end\GloboTicket.TicketManagement.App\Components\Pager.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
