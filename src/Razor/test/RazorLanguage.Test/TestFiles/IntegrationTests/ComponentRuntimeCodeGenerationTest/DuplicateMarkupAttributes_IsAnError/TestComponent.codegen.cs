// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddMarkupContent(1, "\r\n  ");
            builder.OpenElement(2, "a");
            builder.AddAttribute(3, "href", "/cool-url");
            builder.AddAttribute(4, "style", true);
            builder.AddAttribute(5, "disabled", true);
            builder.AddAttribute(6, "href", "/even-cooler-url");
            builder.AddContent(7, "Learn the ten cool tricks your compiler author will hate!");
            builder.CloseElement();
            builder.AddMarkupContent(8, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
