using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace CascadedEditorsSample.GeneralSettings.Pages
{

    [PageAuthorize(typeof(CityRow))]
    public class CityController : Controller
    {
        [Route("GeneralSettings/City")]
        public ActionResult Index()
        {
            return View("~/Modules/GeneralSettings/City/CityIndex.cshtml");
        }
    }
}