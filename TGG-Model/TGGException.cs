using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGG_Model
{
    public class TGGException : Exception
    {
        //custom exception intented to be used for user generated errors
        public TGGException(string exMessage) : base(exMessage) { }
        public TGGException(string exMessage, Exception baseException) : base(exMessage, baseException) { }
    }
}
