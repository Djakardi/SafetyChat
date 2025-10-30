using SafetyChat.Core;
using SafetyChat.MVVM.Model;
using System.Collections.ObjectModel;

namespace SafetyChat.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public required ObservableCollection<MessageModel> Messages { get; set; }
        public required ObservableCollection<ContactModel> Contacts { get; set; }

        /* Commands */

        public RelayCommand? SendCommand { get; set; }
        public required ContactModel SelectedContact { get; set; }

        private string? _message;

        public string? Message
        {
            get { return _message; }
            set { 
                    _message = value;
                    OnPropertyChanged();
                }
        }

        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            Messages.Add(new MessageModel
            {
                UserName = "Allison",
                UsernameColor = "#409aff",
                ImageSource = "https://www.thisisanfield.com/wp-content/uploads/P2022-11-24-FIFA_WC_Brazil_Serbia-67.jpg",
                Message = "Test",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            });

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    UserName = "Alisson",
                    UsernameColor = "#409aff",
                    ImageSource = "https://www.thisisanfield.com/wp-content/uploads/P2022-11-24-FIFA_WC_Brazil_Serbia-67.jpg",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = false
                });
            }

            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel
                {
                    UserName = "Bunny",
                    UsernameColor = "#409aff",
                    ImageSource = "https://www.thisisanfield.com/wp-content/uploads/P2022-11-24-FIFA_WC_Brazil_Serbia-67.jpg",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = true,
                });
            }
            Messages.Add(new MessageModel
            {
                UserName = "Bunny",
                UsernameColor = "#409aff",
                ImageSource = "https://www.thisisanfield.com/wp-content/uploads/P2022-11-24-FIFA_WC_Brazil_Serbia-67.jpg",
                Message = "Last",
                Time = DateTime.Now,
                IsNativeOrigin = true,
            });
            for (int i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactModel
                {
                    UserName = $"Alisson {i}",
                    ImageSource = "https://www.thisisanfield.com/wp-content/uploads/P2022-11-24-FIFA_WC_Brazil_Serbia-67.jpg",
                    Messages = Messages
                });
            }
        }
    }
}
