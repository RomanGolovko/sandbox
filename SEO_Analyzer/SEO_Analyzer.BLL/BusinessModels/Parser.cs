using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using SEO_Analyzer.BLL.DTO;
using SEO_Analyzer.Cross_Cutting.Security;

namespace SEO_Analyzer.BLL.BusinessModels
{
    public class Parser
    {
        ResultDTO result;
        public Parser()
        {
            result = new ResultDTO();
            result.Words = new List<WordDTO>();
        }

        /// <summary>
        /// Start parser / Запускает парсер
        /// </summary>
        /// <param name="allWords">All words option / Опция всех слов</param>
        /// <param name="tagsWords">Tag-words option / Оция тегов</param>
        /// <param name="hrefs">Hrefs option / Опция ссылок</param>
        /// <param name="link">Internet link / Интернет ссылка</param>
        /// <returns>Result / Результат</returns>
        public ResultDTO RunParser(bool allWords, bool tagsWords, bool hrefs, string link)
        {
            string text = GetData(link);

            // validation / валидация
            if (string.IsNullOrEmpty(text))
            {
                throw new ValidationException("Not found!", "");
            }

            if (allWords)
            {
                var str = AllWords(text);
                var textWithOutStoWords = RemoveStopWords(str);
                List<string> wordsList = SplitTextIntoWords(textWithOutStoWords);
                var words = CurrentWordsMatch(text, wordsList);
                foreach (var word in words)
                {
                    result.Words.Add(word);
                }

            }

            if (tagsWords)
            {
                var str = TagsMatch(text);
                var textWithOutStoWords = RemoveStopWords(str);
                List<string> wordsList = SplitTextIntoWords(textWithOutStoWords);
                var words = CurrentWordsMatch(text, wordsList);
                foreach (var word in words)
                {
                    result.Words.Add(word);
                }
            }


            if (hrefs)
            {
                var word = HrefMatch(text);
                if (word != null)
                {
                    result.Words.Add(word);
                }
            }

            result.Link_Text = link;
            return result;
        }

        /// <summary>
        /// Convert html markup to text / Конвертирует html разметку в текст
        /// </summary>
        /// <param name="link">Link / Ссылка</param>
        /// <returns>Text / Текст</returns>
        public string GetData(string link)
        {
            string str = "";

            // request validation / валидация запроса
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);
                request.Timeout = 30000;    // waiting for a valid response / допустимое для ожидания ответа

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader dataFromRequest = new StreamReader(stream))
                    {
                        str = dataFromRequest.ReadToEnd();
                    }
                }

                response.Close();
            }
            catch (WebException ex)
            {
                throw new ValidationException(ex.Message, "");
            }

            catch (Exception ex)
            {
                throw new ValidationException(ex.Message, "");
            }

            return str;
        }

        /// <summary>
        /// Get all words between tags from text / Получает все слова между тегами из текста
        /// </summary>
        /// <param name="text">Text / Текст</param>
        /// <returns>Words / Слова</returns>
        public string AllWords(string text)
        {
            StringBuilder output = new StringBuilder();
            string pattern = "(<.+>)*<.+>\\s*(\\w.*)\\s*</.+>(</.+>)*";
            Match match = Regex.Match(text.ToLower(), pattern);
            while (match.Success)
            {
                output.Append(match.Groups[2].Value);
                match = match.NextMatch();
            }

            pattern = "(</.*>)";
            Regex regex = new Regex(pattern);
            string target = "";
            string result = regex.Replace(output.ToString(), target);

            return result;
        }

        /// <summary>
        /// Remove stop-words / Убирает стоп-слова
        /// </summary>
        /// <param name="text">Text / Текст</param>
        /// <returns>Text without stop-words / Текст без стоп-слов</returns>
        public string RemoveStopWords(string text)
        {
            string pattern = "the |and |a |or |is |-|_|:|;|\"|'|{|}|\\(|\\)";
            string target = "";
            Regex regex = new Regex(pattern);
            string output = regex.Replace(text.ToLower(), target);

            return output;
        }

        /// <summary>
        /// Split text into words and remove repeated / Делит текст на слова и удаляет повторяющиеся
        /// </summary>
        /// <param name="text">Text / Текст</param>
        /// <returns>Words list / Список слов</returns>
        public List<string> SplitTextIntoWords(string text)
        {
            List<string> wordsList = text.Split(new char[] { ' ', '.', ',', '?', '!' },
                StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < wordsList.Count; i++)
            {
                for (int j = i + 1; j < wordsList.Count; j++)
                {
                    if (wordsList[i] == wordsList[j])
                    {
                        wordsList.Remove(wordsList[j]);
                    }
                }
            }

            return wordsList;
        }

        /// <summary>
        /// Сalculates number of occurrences of each word / Вычисляет количество вхождений каждого слова
        /// </summary>
        /// <param name="text">Text / Текст</param>
        /// <param name="wordsList">Words list / Список слов</param>
        /// <returns>Words and occurrences / Слова и вхождения</returns>
        public List<WordDTO> CurrentWordsMatch(string text, List<string> wordsList)
        {
            List<WordDTO> words = new List<WordDTO>();

            foreach (var word in wordsList)
            {
                WordDTO newWord = new WordDTO();
                newWord.Literal = word;
                newWord.Count = text.Split(new string[] { word }, StringSplitOptions.None).Count() - 1;
                words.Add(newWord);
            }

            return words;
        }

        /// <summary>
        /// Get text listed in meta tags / Получает текст из мета-тегов
        /// </summary>
        /// <param name="text">Text / Текст</param>
        /// <returns>Text / Текст</returns>
        public string TagsMatch(string text)
        {
            StringBuilder output = new StringBuilder();
            string pattern = "<\\s*meta\\s*name=[\"'&]\\s*keywords\\s*[\"'&]\\s*content=[\"'&]\\s*(.*)\\s*[\"'&]\\s*.*\\s*>";
            Match match = Regex.Match(text.ToLower(), pattern);

            while (match.Success)
            {
                output.Append(match.Groups[1].Value);
                match = match.NextMatch();
            }

            return output.ToString();
        }

        /// <summary>
        /// Сalculates number of external links / Вычисляет количество внешних ссылок
        /// </summary>
        /// <param name="text">Text / Текст</param>
        /// <returns>Links and its number / Ссылки и их количество</returns>
        public WordDTO HrefMatch(string text)
        {
            int count = 0;
            string pattern = "href\\s*=\\s*(?:[\"'](?<1>[^\"']*)[\"']|(?<1>\\S+))";
            Match match = Regex.Match(text.ToLower(), pattern);

            while (match.Success)
            {
                count++;
                match = match.NextMatch();
            }

            WordDTO word = new WordDTO();
            word.Literal = "References";
            word.Count = count;

            return word;
        }
    }
}
