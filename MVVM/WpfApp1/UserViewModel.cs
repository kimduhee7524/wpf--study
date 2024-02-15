using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    class UserViewModel : ViewModelBase
    {
        private User user;
        private string _email;
        private string _emailValidationResult;

        public UserViewModel()
        {
            ValidateEmailCommand = new RelayCommand(ExecuteValidateEmail);
        }

        public string Email
        {
            get => _email;
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        public string EmailValidationResult
        {
            get => _emailValidationResult;
            set
            {
                if (_emailValidationResult != value)
                {
                    _emailValidationResult = value;
                    OnPropertyChanged(nameof(EmailValidationResult));
                }
            }
        }

        public ICommand ValidateEmailCommand { get; private set; }

        private void ExecuteValidateEmail()
        {
            EmailValidationResult = IsValidEmail(Email) ? "Valid Email" : "Invalid Email";
        }

        private bool IsValidEmail(string email)
        {
            // 간단한 이메일 유효성 검사 로직
            // 실제 애플리케이션에서는 더 강력한 검증 로직을 사용할 수 있습니다.
            return !string.IsNullOrWhiteSpace(email) && email.Contains("@") && email.Contains(".");
        }
    }
}
