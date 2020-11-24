using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Threading.Tasks;

namespace BlazorBoilerplate.Theme.Material.TagHelpers
{
    public class AppTagHelperComponent : TagHelperComponent
    {

        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var path = typeof(Module).Namespace;

            if (string.Equals(context.TagName, "app",
                    StringComparison.OrdinalIgnoreCase) &&
                output.Attributes.ContainsName("wasm"))
            {
                output.PostContent.AppendHtml(@$"
<div class=""triangle-container"">
 <div class=""triangles"">
 </div>
</div>
<div class=""loading-container"">
 <img src=""../images/logo.svg"" alt=""Loading"" title=""Loading Coastal Hub"" /><br />
  Loading BlazorBoilerplate WebAssemblies ...
</div>");
            }

            return Task.CompletedTask;
        }
    }
}
