#pragma checksum "C:\MyWorkItems\GitHub\Blazor\Asp_Net_Core_Blazor.Client\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "845a3f6c1195ecdebd87df88da83b5f95e0f789e"
// <auto-generated/>
#pragma warning disable 1591
namespace Asp_Net_Core_Blazor.Client.Pages
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
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\n\nWelcome to your new app. - bp\n\n\n    ");
            builder.OpenComponent<Asp_Net_Core_Blazor.Client.Shared.SurveyPrompt>(1);
            builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
