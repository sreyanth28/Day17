using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace CustomerFeedbackPortal.TagHelpers
{
    [HtmlTargetElement("star-rating")]
    public class StarRatingTagHelper : TagHelper
    {
        public int MaxStars { get; set; } = 5;

        public string InputName { get; set; } = string.Empty;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";

            var content = new StringBuilder();

            for (int i = 1; i <= MaxStars; i++)
            {
                content.Append($@"
                    <input type='radio' name='{InputName}' value='{i}' /> {i} ⭐
                ");
            }

            output.Content.SetHtmlContent(content.ToString());
        }
    }
}