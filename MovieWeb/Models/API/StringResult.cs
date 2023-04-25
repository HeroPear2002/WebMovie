namespace MovieWeb.Models.API
{
    public class StringResult
    {
        public StringResult(string result)
        {
            Result = result;
        }
        public string Result { get; set; }
    }
}
