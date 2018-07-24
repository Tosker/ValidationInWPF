using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Validation_ByAnnotations
{
    public class RegistrationVM : ObservableObject
    {
        private string _username;

        [Required(ErrorMessage = "Must not be empty.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Must be at least 5 characters.")]
        public string Username
        {
            get { return _username; }
            set
            {
                ValidateProperty(value, "Username");
                OnPropertyChanged(ref _username, value);
            }
        }

        private void ValidateProperty<T>(T value, string name)
        {
            Validator.ValidateProperty(value, new ValidationContext(this, null, null)
            {
                MemberName = name
            });
        }
    }
}
