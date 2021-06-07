namespace TypedApiService
{
    public class WebResponse<T>
    {
        public T Payload { get; private set; }
        public string ErrorMessage { get; private set; }
        public bool IsSuccessful { get; private set; }

        public WebResponse(bool isSuccessful, T payload, string errorMessage = null)
        {
            IsSuccessful = isSuccessful;
            Payload = payload;
            ErrorMessage = errorMessage;
        }
    }
}
