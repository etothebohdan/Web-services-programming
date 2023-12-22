using System.IO;
using System.Security.Claims;
using System.Web.Mvc;

namespace UploadFile
{
    public class UploadController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upload()
        {
            // Отримати файл з форми
            var file = Request.Form.Fale["file"];

            // Перевірити, чи є файл
            if (file == null)
            {
                return RedirectToAction("Index");
            }

            // Перевірити розмір файлу
            if (file.ContentLength > 1024 * 1024)
            {
                return Content("Файл занадто великий!");
            }

            // Перевірити тип файлу
            if (file.ContentType != "image/jpeg" && file.ContentType != "image/png")
            {
                return Content("Недопустимий тип файлу!");
            }

            // Зберегти файл
            string filename = Path.GetFileName(file.FileName);
            file.SaveAs(Path.Combine("wwwroot/Files", filename));

            // Повернути повідомлення
            return Content("Файл успішно завантажено!");
        }
    }
}