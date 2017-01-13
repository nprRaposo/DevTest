using System.Web.Mvc;

namespace DevTest.Web.Areas.Campaigns
{
    public class CampaignsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Campaigns";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
			context.MapRoute(
				"Campaign_default",
				"Campaigns/{controller}/{action}/{id}",
				new { controller = "Campaigns", action = "Index", id = UrlParameter.Optional }
			);
        }
    }
}