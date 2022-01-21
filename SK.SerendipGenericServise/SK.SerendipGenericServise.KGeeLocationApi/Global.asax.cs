
using SK.SerendipGenericServise.KGeoLocationApi.App_Start;
using System.Web.Http;
using System.Web.Mvc;

namespace SK.SerendipGenericServise.KGeoLocationApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        protected void Application_PostAuthorizeRequest()
        {
            System.Web.HttpContext.Current.SetSessionStateBehavior(System.Web.SessionState.SessionStateBehavior.Required);
        }
    }
}
