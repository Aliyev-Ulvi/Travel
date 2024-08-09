﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers.Result.Concrete
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {
            
        }

        public ErrorDataResult(T data) : base(data, false)
        {
            
        }

        public ErrorDataResult() : base(default, false)
        {
            
        }
    }
}
