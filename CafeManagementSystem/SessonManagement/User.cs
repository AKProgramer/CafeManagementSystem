using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.SessonManagement
{
    internal class User
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string role { get; set; }
    }
}
