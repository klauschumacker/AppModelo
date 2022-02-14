using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevT800.UI.Site.Extensions
{
    public class EmailTagHelper : TagHelper
    {
        /*public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var content = await output.GetChildContentAsync();
            var target = content.GetContent() + "@" + "desenvolvedor.io";
            output.Attributes.SetAttribute("href", "mailto:" + target);
            output.Content.SetContent(target);
        }
        http://www.macoratti.net/17/12/aspncore_ctaghlp1.htm
        
        Obs: Versao acima não funciona
        
         */

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string emailTo = context.AllAttributes["mailTo"].Value.ToString();
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" + emailTo);
            output.Content.SetContent("developer.backend@icloud.com");
        }
    }
}