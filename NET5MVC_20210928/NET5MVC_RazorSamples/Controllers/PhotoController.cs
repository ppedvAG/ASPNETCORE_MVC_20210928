using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NET5MVC_RazorSamples.Controllers
{
    public class PhotoController : Controller
    {
        [HttpGet]
        public IActionResult UploadPicture()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadPicture(IFormFile datei)
        {

            if (datei == null)
                ModelState.AddModelError("datei", "Bitte eine Datei auswählen, bevor wir Upload klicken");

            if (ModelState.IsValid)
            {
                FileInfo fileInfo = new FileInfo(datei.FileName);

                //Wo speichern wir unsere Bilder ab? 
                //savePath ist ein Absoluter Pfad
                string savePath = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images\" + fileInfo.Name;

                using (FileStream stream = new FileStream(savePath, FileMode.Create))
                {
                    await datei.CopyToAsync(stream);
                }

                return RedirectToAction(nameof(UploadPicture)); //Wenn Bild hochgeladen wurde, wird das Upload-Formular neu angezeigt
            }
            return View();
        }


        [HttpGet]
        public IActionResult PictureGallery()
        {
            string imgageDirectoryPath = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images\";

            string[] bilder = Directory.GetFiles(imgageDirectoryPath);

            return View(bilder);
        }
    }
}
