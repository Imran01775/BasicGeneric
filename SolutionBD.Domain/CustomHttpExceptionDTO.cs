using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionBD.Domain
{
    public class CustomHttpExceptionDTO
    {
        public string Message { set; get; }
        public int MessageCode { set; get; }
    }
}
