using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SK.SerendipGenericService.KSubeApi.Controllers
{
    public class BaseController : ApiController
    {
        public BaseController()
        {
            Authenticate();
        }
        private bool Authenticate()
        {
            string defaultDatabase = ConfigurationManager.AppSettings["DefaultDatabase"];
            string defaultUsername = ConfigurationManager.AppSettings["DefaultUsername"];
            string defaultPassword = ConfigurationManager.AppSettings["DefaultPassword"];
            return Serendip.Server.Provider.ServicesProviderService.AuthenticationService.Login(defaultUsername, defaultPassword, defaultDatabase);
        }
    }
}