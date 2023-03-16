using Microsoft.AspNetCore.Mvc;

namespace ControllersExample.Controllers
{
    [Controller]
    public class HomeController //: Controller 
    {
        [Route("home")]
        [Route("/")]
        public string Index() 
        {
            return "Hello From Index";
        }

        [Route("about")]
        public string About()
        {
            return "Hello From About";
        }

        [Route("contact-us/{mobile:regex(^\\d{{10}}$)}")]
        public string Contact()
        {
            return "Hello From Contact";
        }

        [Route("contact-gr")]
        public string ContactGr()
        {
            return "Γεια σου από Ελλάδα";
        }

    }
}
