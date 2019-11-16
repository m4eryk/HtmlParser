using AngleSharp.Html.Dom;


namespace ParserHTML.core
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
