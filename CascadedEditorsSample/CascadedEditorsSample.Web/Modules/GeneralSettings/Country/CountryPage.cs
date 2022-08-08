using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace CascadedEditorsSample.GeneralSettings.Pages
{

    [PageAuthorize(typeof(CountryRow))]
    public class CountryController : Controller
    {
        [Route("GeneralSettings/Country")]
        public ActionResult Index()
        {
            return View("~/Modules/GeneralSettings/Country/CountryIndex.cshtml");
        }
    }
}