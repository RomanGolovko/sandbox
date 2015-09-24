using System.Collections.Generic;
using SEO_Analyzer.BLL.DTO;

namespace SEO_Analyzer.BLL.Abcstract
{
    public interface IResultService
    {
        /// <summary>
        /// Get all results / Получает все результаты
        /// </summary>
        /// <returns>All results / Все результаты</returns>
        IEnumerable<ResultDTO> GetResults();

        /// <summary>
        /// Get current result / Получает актуальный результат
        /// </summary>
        /// <param name="id">Result id / Id результата</param>
        /// <returns>Current result / Актуальный результат</returns>
        ResultDTO GetResult(int? id);

        /// <summary>
        /// Add result / Добавляет результат
        /// </summary>
        /// <param name="allWords">All words option / Опция всех слов</param>
        /// <param name="tagsWords">Tag-words option / Оция тегов</param>
        /// <param name="hrefs">Hrefs option / Опция ссылок</param>
        /// <param name="link">Internet link / Интернет ссылка</param>
        void AddResult(ResultDTO resultDTO);
    }
}
