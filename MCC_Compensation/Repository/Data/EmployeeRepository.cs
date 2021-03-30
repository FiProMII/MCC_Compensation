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
    public class EmployeeRepository : GeneralRepository<MyContext, Employee, string>
    {
        public IConfiguration _configuration;
        readonly DynamicParameters _parameters = new DynamicParameters();

        public EmployeeRepository(MyContext myContext, IConfiguration configuration) : base(myContext)
        {
            _configuration = configuration;
        }

        public Employee Validation(string Params)
        {
            var _employeeRepository = new GeneralDapperRepository<Employee>(_configuration);

            _parameters.Add("@Params", Params);
            var result = _employeeRepository.SingleGet("SP_RetrieveValidation", _parameters);
            return result;
        }
    }
}
