using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.DTO;
using Cross_Cutting.Security;
using PresentationLayer.WebUI.Models;

namespace PresentationLayer.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IBugReportService service;
        public HomeController(IBugReportService serv)
        {
            service = serv;
        }

        // GET: Home
        public ActionResult Index()
        {
            // using automapper for the projection of one collection to another /
            // применяем автомаппер для проекции одной коллекции на другую
            Mapper.CreateMap<BugReportDTO, BugReportViewModel>();
            var reports = Mapper.Map<IEnumerable<BugReportDTO>, List<BugReportViewModel>>(service.GetAllReports());

            return View(reports);
        }

        // POST: Home/Result
        [HttpPost]
        public ActionResult Search(string serchedName)
        {
            try
            {
                // using automapper for the projection of one collection to another /
                // применяем автомаппер для проекции одной коллекции на другую
                Mapper.CreateMap<BugReportDTO, BugReportViewModel>();
                var reports = Mapper.Map<IEnumerable<BugReportDTO>, List<BugReportViewModel>>(
                    service.GetSearchedReports(serchedName));

                return PartialView(reports);
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
                TempData["message"] = ex.Message;

                return RedirectToAction("Index");
            }
        }

        // GET: Home/Details/5
        public ActionResult Details(int? id)
        {
            BugReportViewModel reportViewModel = new BugReportViewModel();
            try
            {
                // using automapper for the projection of one collection to another /
                // применяем автомаппер для проекции одной коллекции на другую
                Mapper.CreateMap<BugReportDTO, BugReportViewModel>();
                reportViewModel = Mapper.Map<BugReportDTO, BugReportViewModel>(service.GetCurrentReport(id));
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
                TempData["message"] = ex.Message;
            }

            return View(reportViewModel);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View("Edit", new BugReportViewModel());
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int? id)
        {
            BugReportViewModel reportViewModel = new BugReportViewModel();
            try
            {
                // using automapper for the projection of one collection to another /
                // применяем автомаппер для проекции одной коллекции на другую
                Mapper.CreateMap<BugReportDTO, BugReportViewModel>();
                reportViewModel = Mapper.Map<BugReportDTO, BugReportViewModel>(service.GetCurrentReport(id));
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
                TempData["message"] = ex.Message;
            }

            return View(reportViewModel);
        }

        // POST: Home/Edit/5
        public ActionResult Edit(BugReportViewModel reportViewModel)
        {
            try
            {
                // using automapper for the projection of one collection to another /
                // применяем автомаппер для проекции одной коллекции на другую
                Mapper.CreateMap<BugReportViewModel, BugReportDTO>();
                var report = Mapper.Map<BugReportViewModel, BugReportDTO>(reportViewModel);
                service.Upsert(report);
                TempData["message"] = string.Format("{0} has been saved", report.Summary);

                return RedirectToAction("Index");
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
                return View(reportViewModel);
            }
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id)
        {
            try
            {
                BugReportDTO deletedReport = service.RemoveReport(id);

                if (deletedReport != null)
                {
                    TempData["message"] = string.Format("{0} was deleted", deletedReport.Summary);
                }

                return RedirectToAction("Index");
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
                return View();
            }
        }

        // GET: Home/About
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        // GET: Home/Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}