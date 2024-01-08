using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLoading
{
    public partial class MainViewModel : ViewModelBase
    {
        private bool _isLoading;
        private string _message;

        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                if (_isLoading != value)
                {
                    _isLoading = value;
                    RaisePropertyChanged(nameof(IsLoading));
                }
            }
        }

        public string Message
        {
            get => _message;
            set
            {
                if (_message != value)
                {
                    _message = value;
                    RaisePropertyChanged(nameof(Message));
                }
            }
        }

        public async Task LoadAsync()
        {
            IsLoading = true;
            Message = "읽는중...";

            await Task.Delay(5000); // 비동기 작업 시뮬레이션

            IsLoading = false;
            Message = "읽기 완료";
        }
    }
}
