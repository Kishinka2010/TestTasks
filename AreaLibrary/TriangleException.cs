using System;
using System.Runtime.Serialization;

namespace AreaLibrary
{
    [Serializable]
    internal class TriangleException : Exception
    {
        public TriangleException()
        {
        }

        public TriangleException(string message) : base(message)
        {
        }

        public TriangleException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TriangleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}