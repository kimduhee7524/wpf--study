using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        // 비즈니스 로직 예시: 이메일 유효성 검사
        public bool IsValidEmail()
        {
            return Email.Contains("@");
        }
    }
}
