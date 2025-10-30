using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafetyChat.MVVM.Model
{
    internal class MessageModel
    {
        public required string UserName { get; set; }
        public required string UsernameColor { get; set; }
        public string? ImageSource { get; set; }
        public required string Message { get; set; }
        public DateTime Time { get; set; }
        public bool IsNativeOrigin { get; set; }
        public bool? FirstMessage { get; set; }

    }
}
