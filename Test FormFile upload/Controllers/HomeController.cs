using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using Test_FormFile_upload.Models;

namespace Test_FormFile_upload.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult MultipleFilesNested()
        {
            MultipleFilesNestedViewModel viewModel = new MultipleFilesNestedViewModel()
            {
                Id = 1,
                SingleFileViewModels = new List<SingleFileViewModel>
                {
                    new SingleFileViewModel{SingleFileId = 11},
                    new SingleFileViewModel{SingleFileId = 12}
                }
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult MultipleFilesNested(MultipleFilesNestedViewModel multipleFilesNestedViewModel)
        {
            return View();
        }
    }
}
