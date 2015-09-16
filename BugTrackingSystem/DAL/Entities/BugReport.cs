using System;

namespace DAL.Entities
{
    public class BugReport
    {
        public int Id { get; set; }                 // идентификатор
        public string summary { get; set; }         // короткое описание проблемы, явно указывающее на причину и тип ошибочной ситуации
        public string project { get; set; }         // название тестируемого проекта
        public string component { get; set; }       // название части или функции тестируемого продукта
        public string version { get; set; }         // версия на которой была найдена ошибка
        public string severity { get; set; }        // серьёзность (критичность) дефекта
        //public enum severity                        // серьёзность (критичность) дефекта
        //{
        //    blocer,
        //    critical,
        //    major,
        //    minor,
        //    trivial
        //}
        public string priority { get; set; }        // приоритет решения
        //public enum priority                        // приоритет решения
        //{
        //    high,
        //    medium,
        //    low
        //}
        public string status { get; set; }          // статус бага
        //public enum status                          
        //{
        //    opened,
        //    resolved,
        //    closed,
        //    reopened,
        //    inProgress
        //}
        public string author { get; set; }          // создатель баг репорта
        public string assignedTo { get; set; }      // сотрудник, назначеный на решение проблемы
        public DateTime foundIn { get; set; }       // когда найден
        public string environment { get; set; }     // информация об окружении, на котором был найден баг
        public string reproduceSteps { get; set; }  // шаги воспроизведения ситуации, приведшей к ошибке
        public string actualResult { get; set; }    // результат, полученный после прохождения шагов к воспроизведению
        public string expectedResult { get; set; }  // ожидаемый результат
        public byte[] attachment { get; set; }      // прикрепленный файл
    }
}
