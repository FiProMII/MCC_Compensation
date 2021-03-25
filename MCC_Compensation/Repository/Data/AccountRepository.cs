using API.Context;
using API.Models;
using API.ViewModels;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace API.Repository.Data
{
    public class AccountRepository : GeneralRepository<MyContext, Account, string>
    {
        private readonly MyContext _myContext;
        private readonly DbSet<Employee> employees;
        private readonly DbSet<AccountRole> accountRoles;

        public AccountRepository(MyContext myContext) : base(myContext)
        {
            _myContext = myContext;
            employees = _myContext.Set<Employee>();
            accountRoles = _myContext.Set<AccountRole>();
        }

        public LoginVM Login(LoginVM loginVM)
        {
            var isTemp = false;
            var employee = employees.Include("Account")
                .SingleOrDefault(e => e.Email == loginVM.Email);
            //BC.EnhancedVerify(loginVM.Password, employee.Account.Password, BCrypt.Net.HashType.SHA384)
            LoginVM loginResult = new LoginVM();
            if (employee != null)
            {
                Regex regex = new Regex("^n");
                if (regex.IsMatch(employee.Account.Password))
                {
                    isTemp = true;
                    regex.Replace(employee.Account.Password, "");
                }

                if (BC.EnhancedVerify(loginVM.Password, employee.Account.Password, BCrypt.Net.HashType.SHA384))
                {
                    var roles = accountRoles.Include("Role")
                        .Where(ar => ar.NIK == employee.NIK)
                        .Select(ar => ar.Role.RoleName);
                    try
                    {
                        loginResult.NIK = employee.NIK;
                        loginResult.Email = employee.Email;
                        loginResult.EmployeeName = employee.EmployeeName;
                        loginResult.Roles = roles;
                        loginResult.IsTemp = isTemp;
                    }
                    catch
                    {
                        return null;
                    }
                }
            }
            return loginResult;
        }

        public bool ForgotPassword(string email)
        {
            var employee = employees.SingleOrDefault(x => x.Email == email);
            if (employee != null)
            {
                Guid g = Guid.NewGuid();
                var tempPassword = BC.EnhancedHashPassword(g.ToString());
                Account account = new Account();
                account.NIK = employee.NIK;
                account.Password = 'n' + tempPassword;
                return true;
            }
            return false;
        }
    }
}
