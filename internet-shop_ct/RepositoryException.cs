using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internet_shop_ct
{
    public class RepositoryException : Exception
    {
        public RepositoryException(int code, string message)
        {
            ErrorCode = code;
            Message = message;
        }

        public RepositoryException(string message)
        {
            Message = message;
        }

        public int ErrorCode { get; private set; }
        public string? Message { get; private set; }
    }
}
