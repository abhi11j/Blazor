#pragma checksum "C:\MyWorkItems\Asp_Net_Core_Blazor\Asp_Net_Core_Blazor.Client\Shared\MainLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd6d20d95fdaaf0db83a6a3154434357438fcf15"
// <auto-generated/>
#pragma warning disable 1591
namespace Asp_Net_Core_Blazor.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using Asp_Net_Core_Blazor.Client;
    using Asp_Net_Core_Blazor.Client.Shared;
    public class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "sidebar");
            builder.AddContent(2, "\n    ");
            builder.OpenComponent<Asp_Net_Core_Blazor.Client.Shared.NavMenu>(3);
            builder.CloseComponent();
            builder.AddContent(4, "\n");
            builder.CloseElement();
            builder.AddContent(5, "\n\n");
            builder.OpenElement(6, "div");
            builder.AddAttribute(7, "class", "main");
            builder.AddContent(8, "\n    ");
            builder.AddMarkupContent(9, "<div class=\"top-row px-4\">\n        <a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a>\n    </div>\n\n    ");
            builder.OpenElement(10, "div");
            builder.AddAttribute(11, "class", "content px-4");
            builder.AddContent(12, "\n        ");
            builder.AddContent(13, Body);
            builder.AddContent(14, "\n    ");
            builder.CloseElement();
            builder.AddContent(15, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
