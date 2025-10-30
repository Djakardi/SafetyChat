using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafetyChat.MVVM.Model
{
    internal class ContactModel
    {
        public required string UserName { get; set; }
        public string? ImageSource { get; set; }
        public ObservableCollection<MessageModel>? Messages { get; set; }
        public string? LastMessage => Messages != null && Messages.Any() ? Messages.Last().Message : null;
    }
}
