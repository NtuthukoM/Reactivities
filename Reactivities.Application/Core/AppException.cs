using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Core
{
    public class AppException
    {
        public AppException(int statusCode, string message, string? details = null)
        {
            StatusCode = statusCode;
            Details = details;
            Message = message;
        }

        public int StatusCode { get; set; }
        public string? Details { get; set; }
        public string Message { get; set; }
    }
}
