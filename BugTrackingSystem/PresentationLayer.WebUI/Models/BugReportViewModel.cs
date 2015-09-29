using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace PresentationLayer.WebUI.Models
{
    public class BugReportViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int? Id { get; set; }                 // идентификатор

        [Required(ErrorMessage = "Enter bug short description")]
        [DataType(DataType.MultilineText)]
        public string Summary { get; set; }         // короткое описание проблемы, явно указывающее на причину и тип ошибочной ситуации

        [Required(ErrorMessage = "Enter testing project name")]
        public string Project { get; set; }         // название тестируемого проекта

        [Required(ErrorMessage = "Enter component of testing project name")]
        public string Component { get; set; }       // название части или функции тестируемого продукта

        [Required(ErrorMessage = "Enter version of testing project name")]
        public string Version { get; set; }         // версия на которой была найдена ошибка

        public string Severity { get; set; }        // серьёзность (критичность) дефекта

        public string Priority { get; set; }        // приоритет решения

        public string Status { get; set; }          // статус бага

        [Required(ErrorMessage = "Enter author of bug report")]
        public string Author { get; set; }          // создатель баг репорта

        [Display(Name = "Assigned To")]
        public string AssignedTo { get; set; }      // сотрудник, назначеный на решение проблемы

        [HiddenInput(DisplayValue = false)]
        public DateTime FoundIn { get; set; }       // когда найден

        [Required(ErrorMessage = "Enter environment info")]
        [DataType(DataType.MultilineText)]
        public string Environment { get; set; }     // информация об окружении, на котором был найден баг

        [Required(ErrorMessage = "Enter bug steps to reproduce")]
        [Display(Name = "Steps to Reproduce")]
        [DataType(DataType.MultilineText)]
        public string ReproduceSteps { get; set; }  // шаги воспроизведения ситуации, приведшей к ошибке

        [Required(ErrorMessage = "Enter test actual result")]
        [Display(Name = "Actual Result")]
        [DataType(DataType.MultilineText)]
        public string ActualResult { get; set; }    // результат, полученный после прохождения шагов к воспроизведению

        [Required(ErrorMessage = "Enter test expected result")]
        [Display(Name = "Expected Result")]
        [DataType(DataType.MultilineText)]
        public string ExpectedResult { get; set; }  // ожидаемый результат

        [DataType(DataType.Upload)]
        public byte[] Attachment { get; set; }      // прикрепленный файл
    }
}