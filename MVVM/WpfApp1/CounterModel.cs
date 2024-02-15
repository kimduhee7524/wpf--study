using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class CounterModel
    {
        public event EventHandler CountChange;

        public int m_Count { get; private set; } = 0;

        public void IncrementCount()
        {
            m_Count++;
        }

        public void OnMenuNameChanged()
        {
            if (CountChange != null)
                CountChange(this, null);
        }
    }
}
