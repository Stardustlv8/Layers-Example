using System;

namespace BLL
{
    public class ErroEventArgs : EventArgs
    {
        public ErroEventArgs(string Message)
        {
            this.Message = Message;
        }
        public string Message { get; set; }
    }
}