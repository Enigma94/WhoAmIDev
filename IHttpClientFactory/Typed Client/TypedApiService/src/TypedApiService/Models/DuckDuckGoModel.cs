namespace TypedApiService.Models
{

    public class DuckDuckGoModel
    {
        public string Abstract { get; set; }
        public string AbstractSource { get; set; }
        public string AbstractText { get; set; }
        public string AbstractURL { get; set; }
        public Relatedtopic[] RelatedTopics { get; set; }
    }

    public class Relatedtopic
    {
        public string FirstURL { get; set; }
        public string Result { get; set; }
        public string Text { get; set; }
    }
}
