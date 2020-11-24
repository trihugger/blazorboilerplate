using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Threading.Tasks;
using BlazorBoilerplate.Shared.Models;

namespace BlazorBoilerplate.Theme.Material.TagHelpers
{
    public class ThemeTagHelperComponent : TagHelperComponent
    {
        public override int Order => 1;
        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var path = typeof(Module).Namespace;

            if (string.Equals(context.TagName, "head", StringComparison.OrdinalIgnoreCase))
            {
                output.PostContent.AppendHtml(@$"
<link rel=""shortcut icon"" type=""image/x-icon"" href=""_content/{path}/images/favicon.ico"">
<link rel=""icon"" type=""image/x-icon"" href=""_content/{path}/images/favicon.ico"">
<link href=""_content/{path}/css/bootstrap/bootstrap.min.css"" rel=""stylesheet"" />
<link href=""https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet"" />
<link href=""_content/{path}/fonts/roboto/roboto.css"" rel=""stylesheet"" />
<link href=""_content/MatBlazor/dist/matBlazor.css"" rel=""stylesheet"" />
<link href=""_content/{path}/css/site.css"" rel=""stylesheet"" />");
                //Theme White-labelling
                output.PostContent.AppendHtml(@$"<style>        
                    :root {{
                        --mdc-theme-primary: var(--PrimaryColor);
                        --mdc-theme-secondary: var(--SecondaryColor);
                        --mdc-theme-text-primary: var(--OnPrimaryColor);
                        --mdc-theme-text-secondary: var(--OnSecondayColor);
                        --mdc-theme-text-on-primary: var(--OnPrimaryColor);
                        --mdc-theme-text-on-secondary: var(--OnSecondaryColor);}}

                .triangle-container {{ background-color: var(--PrimaryColor); }}
                .mdc-top-app-bar__section .mdc-icon-button i {{ color: var(--PrimaryColor); }}
                .drawer-logo {{
                    background-color: var(--BackgroundColor);
                    color: var(--TextPrimaryColor);
                }}
                .mdc-dialog__title {{
                    color: #fff !important;
                    background-color: var(--BackgroundColor);
                }}
                .mdc-drawer__content {{
                    background-image: linear-gradient(var(--NavOrientation), var(--NavPrimaryColor) 0%, var(--NavSecondaryColor) var(--NavSplit));
                    color: var(--onPrimaryColor) !important;
                }}
                    .mdc-dialog .mdc-dialog__surface {{ max-width: 90vw; align-self:center;}}
                    .mdc-drawer .mdc-list-item--disabled {{ color: var(--OnSecondaryColor) !important; opacity: 50%; }}
                    .mdc-drawer .mdc-list-item {{ color: var(--OnPrimaryColor) !important; }}
                </style>");
            }
            else if (string.Equals(context.TagName, "body", StringComparison.OrdinalIgnoreCase))
            {
                output.PostContent.AppendHtml(@$"
<script src=""_content/MatBlazor/dist/matBlazor.js""></script>");
            }

            return Task.CompletedTask;
        }
    }
}
