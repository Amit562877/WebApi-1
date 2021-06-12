using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.BaseResponseModels
{
    public class ResponseModel
    {
        public int code { get; set; }
        public object data { get; set; }
        public string message { get; set; }

    }
}
