using Microsoft.AspNetCore.Mvc;
using System.Text;
using Lr7.Interfaces;

namespace Lr7.Controllers
{
    public class FileController : Controller
    {
        private readonly IFileService _fileService;

        public FileController(IFileService fileService)
        {
            _fileService = fileService;
        }

        [HttpGet]
        [Route("/")]
        [Route("File/DownloadFile")]
        public IActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost]
        [Route("File/DownloadFile")]
        public IActionResult DownloadFile(string firstName, string lastName, string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                fileName = "default.txt";
            }
            else
            {
                fileName = fileName + ".txt";
            }

            var fileBytes = _fileService.CreateFile(firstName, lastName);

            return File(fileBytes, "text/plain", fileName);
        }
    }
}