using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class NewInvalidCastException : InvalidCastException
    {
        private DateTime time;
        public DateTime Time { get => time; set => time = value; }

        public NewInvalidCastException() : base() { }

        public NewInvalidCastException(string message) : base(message)
        {
        }
    }
}
