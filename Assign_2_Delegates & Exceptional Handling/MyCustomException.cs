using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOperations

{
    public class MyCustomException :Exception
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }

        public MyCustomException(int errorCode, string errorMessage)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }

        public override string ToString()
        {
            return $"Error Code: {ErrorCode}, Message: {ErrorMessage}";
        }
    }
}
