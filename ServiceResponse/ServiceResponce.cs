namespace ServiceResponse
{
    public enum ServiceResultStatus
    {
        Fail,
        Success
    }
    /// <summary>
    /// This class aim is that create standardization rules to functions return object. This structure has a few benefit like that I showed in below
    ///===================================================================
    /// Help you to code standartizion and coverage of code's purpose
    /// Look at the "SampleApplication.Task/PersonTask.cs" class to see implementation.
    /// 
    /// Type Safety and Error Preventing (like not found rec on Db exception)
    /// 
    /// Encoruge To use SOLID prencibles and develope execeture and private method in class
    /// ===================================================================
    /// 
    /// For those aim that shown above , "Generic Safety Class" idea was used on this class.
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
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