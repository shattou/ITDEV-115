using System;


namespace CustomException
{
    public class FloatingPtDivisionException : ApplicationException
    {
        public FloatingPtDivisionException(string exceptionType) : base(exceptionType)
        {

        }
    }
}
