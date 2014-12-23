using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebInterface.Controllers
{
    public class DownloadController : AsyncController
    {
        public ActionResult Download()
        {
            return View();
        }

        public void DownloadZipAsync()
        {
            AsyncManager.OutstandingOperations.Increment();
            var task = new Task(() => CreateZipForDownload());
            task.Start();
        }

        public FileStreamResult DownloadZipCompleted()
        {
            return null;
            //create zip
            //add to parameters collection for completed method.
        }

        private void CreateZipForDownload()
        {
            AsyncManager.OutstandingOperations.Decrement();
        }
	}
}