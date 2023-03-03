using System;

namespace WinFormsSample
{
    public class SaveEventArgs : EventArgs
    {
        public SaveEventArgs(bool isSaved, string errorDetails)
        {
            IsSaved = isSaved;
            ErrorDetails = errorDetails;
        }

        public bool IsSaved { get; }

        public string ErrorDetails { get;}
    }
}