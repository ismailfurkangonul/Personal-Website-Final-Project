﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.IsmailFurkan.Shared.Result
{
    public class Result : IResult
    {
        public int Status { get; }

        public List<string> Message { get; }

        public string Exception { get; }

        public Result(int status, List<string> message, Exception exception)
        {
            Status = status;
            Message = message;
            Exception = exception.Message;

        }
        public Result(int status, List<string> message)
        {
            Status = status;
            Message = message;

        }
    }
}
