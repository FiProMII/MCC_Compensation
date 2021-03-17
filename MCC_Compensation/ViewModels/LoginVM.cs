using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class LoginVM
    {
        [DataType(DataType.EmailAddress)]
        public string Email { set; get; }

        [DataType(DataType.Password)]
        public string Password { set; get; }
        public string EmployeeName { get; set; }
        public IEnumerable<string> Roles { set; get; }

        public string RoleName { set; get; }

    }
}
