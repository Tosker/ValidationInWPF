using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Validation_ByDataErrorInfo
{
    public class RegistrationVM : ObservableObject
    {
        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                OnPropertyChanged(ref _username, value);
            }
        }
    }
}
