using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GRII_TEST.Models;

namespace GRII_TEST.Controllers
{
    public class GRIITESTController : Controller
    {
        // GET: GRIITEST
        public ActionResult Index()
        {
            string[] filePaths = Directory.GetFiles(Server.MapPath("~/images_content/"));
            List<Slider> files = new List<Slider>();
            foreach (string filePath in filePaths)
            {
                string fileName = Path.GetFileName(filePath);
                files.Add(new Slider
                {
                    title = fileName.Split('.')[0].ToString(),
                    src = "/images_content/" + fileName
                });
            }

            return View(files);
        }

        public ActionResult Visi_Misi()
        {
            return View();
        }

        public ActionResult Pengakuan_Iman()
        {
            return View();
        }
        public ActionResult Beban_Doa()
        {
            return View();
        }
        public ActionResult Profil_Hamba_Tuhan()
        {
            return View();
        }
        public ActionResult Gerakan_Grii()
        {
            return View();
        }
        public ActionResult Kegiatan()
        {
            return View();
        }
    }
}