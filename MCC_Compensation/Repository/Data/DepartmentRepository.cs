using API.Context;
using API.Models;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Data
{
    public class DepartmentRepository : GeneralRepository<MyContext, Department, int>
    {
        public IConfiguration _configuration;
        public DepartmentRepository(MyContext myContext, IConfiguration configuration) : base(myContext)
        {
            _configuration = configuration;
        }

        public IEnumerable<Department> GetList()
        {
            var _employeeRepository = new GeneralDapperRepository<Department>(_configuration);
            var SPName = "SP_RetrieveDepartment";
            var result = _employeeRepository.MultipleGet(SPName, null);
            return result;
        }
    }
}
