using System;

namespace BusinessLayer.DTO
{
    public class BugReportDTO
    {
        public int Id { get; set; }                 // идентификатор
        public string Summary { get; set; }         // короткое описание проблемы, явно указывающее на причину и тип ошибочной ситуации
        public string Project { get; set; }         // название тестируемого проекта
        public string Component { get; set; }       // название части или функции тестируемого продукта
        public string Version { get; set; }         // версия на которой была найдена ошибка
        public string Severity { get; set; }        // серьёзность (критичность) дефекта
        public string Priority { get; set; }        // приоритет решения
        public string Status { get; set; }          // статус бага
        public string Author { get; set; }          // создатель баг репорта
        public string AssignedTo { get; set; }      // сотрудник, назначеный на решение проблемы
        public DateTime FoundIn { get; set; }       // когда найден
        public string Environment { get; set; }     // информация об окружении, на котором был найден баг
        public string ReproduceSteps { get; set; }  // шаги воспроизведения ситуации, приведшей к ошибке
        public string ActualResult { get; set; }    // результат, полученный после прохождения шагов к воспроизведению
        public string ExpectedResult { get; set; }  // ожидаемый результат
        public byte[] Attachment { get; set; }      // прикрепленный файл
    }
}
