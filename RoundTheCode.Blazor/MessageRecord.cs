using System;

namespace RoundTheCode.Blazor
{
    public class MessageRecord
    {
        public virtual string Message { get; set; }

        public virtual DateTimeOffset Sent { get; }

        public virtual bool Verified { get; set; }

        public MessageRecord(string message, DateTimeOffset sent)
        {
            Message = message;
            Sent = sent;
        }
    }
}
