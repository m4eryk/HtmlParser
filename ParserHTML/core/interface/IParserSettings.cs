namespace ParserHTML.core
{
    interface IParserSettings
    {
        string BaseURl { get; set; }

        string Prefix { get; set; }

        int StartPoint { get; set; }

        int EndPoint { get; set;  }
    }
}
