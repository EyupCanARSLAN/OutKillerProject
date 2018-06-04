namespace ServiceResponse
{
    /// <summary>
    /// Status code of the response.
    /// </summary>
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
        /// <summary>
        /// Result status.
        /// </summary>
        public ServiceResultStatus Status { get; set; }
        /// <summary>
        /// Message that can be use when status is fail.
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Data that can be use when status is success to return object.
        /// </summary>
        public T Data { get; set; }
        /// <summary>
        /// Response type for success type.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static ServiceResult<T> SuccessResponse(T data = default(T)) => ServiceResponse(ServiceResultStatus.Success, data);
        /// <summary>
        /// Response type for fail type.
        /// </summary>
        /// <param name="failMessage">Progress fail reason can be explained as string</param>
        /// <param name="failedData">Returning object when progress fail.</param>
        /// <returns></returns>
        public static ServiceResult<T> FailResponse(string failMessage = null, T failedData = default(T)) => ServiceResponse(ServiceResultStatus.Fail, failedData, failMessage);
        /// <summary>
        /// A body of Service Result that calling from FailResponse and SuccessResponse
        /// </summary>
        /// <param name="serviceResult">Status of result</param>
        /// <param name="data">Returning object as result item</param>
        /// <param name="message"></param>
        /// <returns></returns>
        private static ServiceResult<T> ServiceResponse(ServiceResultStatus serviceResult, T data = default(T), string message = null) => new ServiceResult<T>
        {
            Status = serviceResult,
            Message = message,
            Data = data
        };
    }
}