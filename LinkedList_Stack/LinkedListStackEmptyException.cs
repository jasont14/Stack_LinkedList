using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Stack
{
    [Serializable]
    public class LinkedListStackEmptyException : Exception
    {
        public LinkedListStackEmptyException() { }
        public LinkedListStackEmptyException(string message) : base(message) { }
        public LinkedListStackEmptyException(string message, Exception inner) : base(message, inner) { }
        protected LinkedListStackEmptyException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

}
