using System.Collections.Generic;

namespace SEO_Analyzer.BLL.DTO
{
    public class ResultDTO
    {
        public int Id { get; set; }
        public string Link_Text { get; set; }
        public List<WordDTO> Words { get; set; }
    }
}
