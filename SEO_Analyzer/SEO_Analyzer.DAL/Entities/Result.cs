using System.Collections.Generic;

namespace SEO_Analyzer.DAL.Entities
{
    public class Result
    {
        public int Id { get; set; }
        public string Link_Text { get; set; }
        public List<Word> Words { get; set; }
    }
}
