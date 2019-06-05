using System;
using System.Collections.Generic;
using System.Text;

namespace Tiendeo.BLL.Exceptions
{
    public class CityDoesNotExistException : Exception
    {
        public CityDoesNotExistException(string message)
            : base(message)
        {
        }
    }
}
