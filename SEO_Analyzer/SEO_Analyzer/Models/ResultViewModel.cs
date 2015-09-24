using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SEO_Analyzer.Models
{
    public class ResultViewModel
    {
        public int Id { get; set; }
        public string Link_Text { get; set; }
        public List<WordViewModel> Words { get; set; }
    }
}