using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace CascadedEditorsSample.GeneralSettings.Pages
{

    [PageAuthorize(typeof(CustomerRow))]
    public class CustomerController : Controller
    {
        [Route("GeneralSettings/Customer")]
        public ActionResult Index()
        {
            return View("~/Modules/GeneralSettings/Customer/CustomerIndex.cshtml");
        }
    }
}