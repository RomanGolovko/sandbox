namespace SEO_Analyzer.DAL.Entities
{
    public class Word
    {
        public int Id { get; set; }
        public string Literal { get; set; }
        public int Count { get; set; }

        public int ResultId { get; set; }
        public Result Result { get; set; }  // navigation property
    }
}
