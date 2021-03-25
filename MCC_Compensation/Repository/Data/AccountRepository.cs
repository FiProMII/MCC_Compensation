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
using System.Threading.Tasks;

namespace API.Repository.Data
{
    public class AccountRepository : GeneralRepository<MyContext, Account, string>
    {
        private readonly MyContext _myContext;
        private readonly DbSet<Employee> employees;
        private readonly DbSet<Account> accounts;
        private readonly DbSet<AccountRole> accountRoles;
        private readonly DbSet<Role> roles;

        public AccountRepository(MyContext myContext) : base(myContext)
        {
            _myContext = myContext;
            employees = _myContext.Set<Employee>();
            accounts = _myContext.Set<Account>();
            accountRoles = _myContext.Set<AccountRole>();
            roles = _myContext.Set<Role>();
    }

        public LoginVM Login(LoginVM loginVM)
        {

            //var _userRepository = new GeneralDapperRepository<LoginVM>(_configuration);

            //_parameters.Add("@Email", loginVM.Email);
            //_parameters.Add("@Password", loginVM.Password);
            //var result = _userRepository.MultipleGet("SP_RetrieveLogin", _parameters);

            LoginVM loginResult = new LoginVM();
            //try
            //{
            //    loginResult.Email = result.FirstOrDefault().Email;
            //    loginResult.EmployeeName = result.FirstOrDefault().EmployeeName;
            //    loginResult.Roles = result.Select(x => x.RoleName);
            //} 
            //catch
            //{
            //        return null;
            //}
            return loginResult;
        }
    }
}
