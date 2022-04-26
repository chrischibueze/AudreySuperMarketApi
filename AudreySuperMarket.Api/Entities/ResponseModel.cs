using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudreySuperMarket.Api.Entities
{
    public class ResponseModel
    {
        public ResponseModel(ResponseCode responseCode, string message, object data)
        {
            ResponseCode = responseCode;
            Message = message;
            Data = data;
        }
        public ResponseCode ResponseCode { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

    }
}
