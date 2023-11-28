using System;

namespace Hello_Exception_stud
{

    #region Opr1

    public class BirdFlewAwayException : ApplicationException
    {
        public DateTime When { get; set; }
        public string Why { get; set; }

        public BirdFlewAwayException() { }

        public BirdFlewAwayException( string message, string cause, DateTime time )
            : base(message)
        {
            Why = cause;
            When = time;
        }

    }
    #endregion
}
