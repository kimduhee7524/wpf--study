using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;

namespace WpfApp1
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private CounterModel _model = new CounterModel();

        public event PropertyChangedEventHandler PropertyChanged;

        public int Count
        {
            get { return _model.m_Count; }
        }
        public int nCount
        {
            get
            {
                return _model.m_Count;
            }
            set
            {
                _model.OnMenuNameChanged();
            }
        }
    }
}
