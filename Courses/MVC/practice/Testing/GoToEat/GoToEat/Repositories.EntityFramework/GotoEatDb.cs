using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using GoToEat.Core;
using GoToEat.Core.Models;

namespace GoToEat.Repositories.EntityFramework
{   
    public class GotoEatDb : DbContext
    {
        public GotoEatDb() : base("GoToEat")
        {
            
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }

 
public static class HtmlHelpers
{
	public static MvcHtmlString MenuLink(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName)
	{
		var currentAction = htmlHelper.ViewContext.RouteData.GetRequiredString("action");
		var currentController = htmlHelper.ViewContext.RouteData.GetRequiredString("controller");
 
		var builder = new TagBuilder("li")
						  {
							  InnerHtml = htmlHelper.ActionLink(linkText, actionName, controllerName).ToHtmlString()
						  };
 
		if (controllerName == currentController && actionName == currentAction)
			builder.AddCssClass("active");			
 
		return new MvcHtmlString(builder.ToString());
	}
}



}