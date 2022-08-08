using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace CascadedEditorsSample.GeneralSettings.Pages
{

    [PageAuthorize(typeof(DistrictRow))]
    public class DistrictController : Controller
    {
        [Route("GeneralSettings/District")]
        public ActionResult Index()
        {
            return View("~/Modules/GeneralSettings/District/DistrictIndex.cshtml");
        }
    }
}