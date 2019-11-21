using ASP.NETGames.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETGames.Infrastructure.TagHelpers
{
    [HtmlTargetElement(Attributes = "platform-name")]
    public class PlatformIconTagHelper : TagHelper
    {
        public string PlatformName { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);

            var i = new TagBuilder("i");
            i.AddCssClass(GetIcon());
            output.Content.AppendHtml(i);
        }

        private string GetIcon() =>
            PlatformName switch
            {
                "pc" => "icofont-brand-windows",
                "playstation" => "icofont-brand-playstation",
                "xbox" => "icofont-xbox-360",
                "ios" => "icofont-iphone",
                "android" => "icofont-brand-android-robot",
                "mac" => "icofont-brand-apple",
                "linux" => "icofont-brand-linux",
                "nintendo" => "icofont-nintendo",
                "web" => "icofont-web",
                _ => "icofont-game-console"
            };
    }
}
