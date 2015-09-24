using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using SEO_Analyzer.BLL.Abcstract;
using SEO_Analyzer.BLL.BusinessModels;
using SEO_Analyzer.BLL.DTO;
using SEO_Analyzer.Cross_Cutting.Security;
using SEO_Analyzer.Models;

namespace SEO_Analyzer.Controllers
{
    public class HomeController : Controller
    {
        IResultService resultService;
        public HomeController(IResultService service)
        {
            resultService = service;
        }

        public ActionResult Index()
        {
            // using automapper for the projection of one collection to another / 
            // применяем автомаппер для проекции одной коллекции на другую
            Mapper.CreateMap<ResultDTO, ResultViewModel>();
            var results = Mapper.Map<IEnumerable<ResultDTO>, List<ResultViewModel>>(resultService.GetResults());

            return View(results);
        }

        public ActionResult Details(int? id)
        {
            try
            {
                var result = resultService.GetResult(id);
                ViewBag.ResultName = result.Link_Text;
                // using automapper for the projection of one collection to another / 
                // применяем автомаппер для проекции одной коллекции на другую
                Mapper.CreateMap<WordDTO, WordViewModel>();
                var output = Mapper.Map<IEnumerable<WordDTO>, List<WordViewModel>>(result.Words);

                return View(output);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }

        public ActionResult Create()
        {
            ResultViewModel result = new ResultViewModel();

            return View(result);
        }

        public ActionResult Result(ResultViewModel model, bool allWords, bool metaTags, bool hrefs)
        {
            try
            {
                Parser parser = new Parser();
                var resultDTO = parser.RunParser(allWords, metaTags, hrefs, model.Link_Text);
                resultService.AddResult(resultDTO);

                // using automapper for the projection of one collection to another / 
                // применяем автомаппер для проекции одной коллекции на другую
                Mapper.CreateMap<WordDTO, WordViewModel>();

                ResultViewModel resultViewModel = new ResultViewModel();
                resultViewModel.Id = resultDTO.Id;
                resultViewModel.Link_Text = resultDTO.Link_Text;
                resultViewModel.Words = Mapper.Map<IEnumerable<WordDTO>, List<WordViewModel>>(resultDTO.Words);

                return PartialView(resultViewModel);
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
                TempData["message"] = ex.Message;

                return View("Create");
            }
        }
    }
}