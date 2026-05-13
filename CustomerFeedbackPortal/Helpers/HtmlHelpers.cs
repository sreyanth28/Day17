using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerFeedbackPortal.Helpers
{
    public static class HtmlHelpers
    {
        public static IHtmlContent StyledInput(this IHtmlHelper htmlHelper,
            string name,
            string placeholder)
        {
            return new HtmlString(
                $"<input type='text' name='{name}' " +
                $"placeholder='{placeholder}' " +
                $"class='form-control custom-input' />");
        }
    }
}