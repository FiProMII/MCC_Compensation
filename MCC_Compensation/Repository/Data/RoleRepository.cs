using API.Context;
using API.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Data
{
    public class RoleRepository : GeneralRepository<MyContext, Role, int>
    {
        public IConfiguration _configuration;
        public RoleRepository(MyContext myContext, IConfiguration configuration) : base(myContext)
        {
            _configuration = configuration;
        }

        public IEnumerable<Role> GetList()
        {
            var _employeeRepository = new GeneralDapperRepository<Role>(_configuration);
            var SPName = "SP_RetrieveRole";
            var result = _employeeRepository.MultipleGet(SPName, null);
            return result;
        }
    }
}
