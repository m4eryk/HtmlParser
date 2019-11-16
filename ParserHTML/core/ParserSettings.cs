namespace ParserHTML.core
{
    class ParserSettings : IParserSettings
    {
        public ParserSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }
        public string BaseURl { get; set; } = "https://habr.com/ru/news";
        public string Prefix { get; set; } = "page{CurrentId}";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}
