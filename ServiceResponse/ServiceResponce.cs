namespace ServiceResponse
{
    public enum ServiceResultStatus
    {
        Fail,
        Success
    }
    public class ServiceResult<T>
    {
        public ServiceResultStatus Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public static ServiceResult<T> SuccessResponse(T data = default(T)) => ServiceResponse(ServiceResultStatus.Success, data);
        public static ServiceResult<T> FailResponse(string failMessage = null, T failedData = default(T))=> ServiceResponse(ServiceResultStatus.Fail, failedData, failMessage);
        private static ServiceResult<T> ServiceResponse(ServiceResultStatus serviceResult, T data = default(T), string message = null) => new ServiceResult<T>
        {
            Status = serviceResult,
            Message = message,
            Data = data
        };
    }
}