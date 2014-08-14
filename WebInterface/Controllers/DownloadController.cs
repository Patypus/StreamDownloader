using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebInterface.Controllers
{
    public class DownloadController : Controller
    {
        //
        // GET: /Download/
        public ActionResult GetView()
        {
            return PartialView("DownloadPartial");
        }
	}
}