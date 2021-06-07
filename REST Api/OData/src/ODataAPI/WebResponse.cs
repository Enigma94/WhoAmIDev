namespace ODataAPI
{
    public class WebResponse<T>
    {
        public T Payload { get; set; }
        public string ErrorMessage { get; private set; }
        public bool IsSuccessful { get; private set; }

        public WebResponse(T payload, bool isSuccessful, string errorMessage = null)
        {
            Payload = payload;
            IsSuccessful = isSuccessful;
            ErrorMessage = errorMessage;
        }
    }
}
