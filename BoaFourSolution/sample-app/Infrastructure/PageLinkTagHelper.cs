using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using sample_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_app.Infrastructure
{
    // Logic for Links
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PageLinkTagHelper : TagHelper
    {
        private readonly IUrlHelperFactory _helperFactory;

        // To Generate Urls  IUrlHelperFactory Class
        public PageLinkTagHelper(IUrlHelperFactory helperFactory)
        {
            _helperFactory = helperFactory;
        }
        // Access to HttpContext : Request and Response
        [ViewContext]
        public ViewContext ViewContext
        { get; set; }

        // Pagination Information Should be pass to this class
        public PagingInfo PageModel { get; set; }

        public string  PageAction { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {           
            // Get the ITagHelper Information For the Request associated with Context
           IUrlHelper urlHelper= _helperFactory.GetUrlHelper(ViewContext);
            // build Urls
            TagBuilder result = new TagBuilder("div");

            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.Attributes["href"] = urlHelper.Action(PageAction, new { productPage = i });
                tag.InnerHtml.Append(i.ToString());
                result.InnerHtml.AppendHtml(tag);
            }
            output.Content.AppendHtml(result.InnerHtml);
        }


    }
}
