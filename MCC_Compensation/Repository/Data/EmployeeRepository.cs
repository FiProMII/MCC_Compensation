using API.Context;
using API.Models;
using API.ViewModels;
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
            var SPName = "SP_RetrieveValidation";
            _parameters.Add("@Params", Params);
            var result = _employeeRepository.SingleGet(SPName, _parameters);
            return result;
        }

        public IEnumerable<EmployeeListVM> GetEmployee()
        {
            var _employeeRepository = new GeneralDapperRepository<EmployeeListVM>(_configuration);
            var SPName = "SP_RetrieveEmployee";
            var result = _employeeRepository.MultipleGet(SPName, null);
            return result;
        }

        public IEnumerable<ManagerVM> GetManagerList()
        {
            var _employeeRepository = new GeneralDapperRepository<ManagerVM>(_configuration);
            var SPName = "SP_RetrieveManager";
            var result = _employeeRepository.MultipleGet(SPName, null);
            return result;
        }
    }
}
