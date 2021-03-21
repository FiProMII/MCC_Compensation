using API.Context;
using API.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Data
{
    public class AccountRoleRepository : GeneralRepository<MyContext, AccountRole, string>
    {
        public IConfiguration _configuration;
        readonly DynamicParameters _parameters = new DynamicParameters();

        public AccountRoleRepository(MyContext myContext, IConfiguration configuration) : base(myContext)
        {
            _configuration = configuration;
        }

        public IEnumerable<AccountRole> GetAccountRoleByID(string key)
        {
            var _accountRoleRepository = new GeneralDapperRepository<AccountRole>(_configuration);

            _parameters.Add("@nik", key);
            var result = _accountRoleRepository.MultipleGet("SP_RetrieveAccountRoleByID", _parameters);
            return result;
        }
    }
}
