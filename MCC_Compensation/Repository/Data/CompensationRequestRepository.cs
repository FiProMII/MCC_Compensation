using API.Context;
using API.Models;
using API.ViewModels;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Data
{
    public class CompensationRequestRepository : GeneralRepository<MyContext, CompensationRequest, int>
    {
        public IConfiguration _configuration;
        readonly DynamicParameters _parameters = new DynamicParameters();
        private readonly DbSet<Employee> employees;
        private readonly DbSet<AccountRole> accountRoles;
        private readonly MyContext _myContext;
        public CompensationRequestRepository(MyContext myContext, IConfiguration configuration) : base(myContext)
        {
            _myContext = myContext;
            _configuration = configuration;
            employees = _myContext.Set<Employee>();
            accountRoles = _myContext.Set<AccountRole>();
        }

        public IEnumerable<RequestListVM> RequestList(string Status)
        {
            var _crRepository = new GeneralDapperRepository<RequestListVM>(_configuration);

            var SPName = "SP_RetrieveDataStatus";
            _parameters.Add("@Status", Status);
            var result = _crRepository.MultipleGet(SPName, _parameters);
            return result;
        }

        public string GetManagerEmail(string nik)
        {
            string email = null;
            var employee = employees.Where(e => e.NIK == nik).SingleOrDefault();
            email = employees.Where(e => e.NIK == employee.ManagerNIK).SingleOrDefault().Email;
            return email;
        }

        public override int Insert(CompensationRequest compensationRequest)
        {
            if (compensationRequest == null)
                throw new ArgumentNullException("entity");
            entities.Add(compensationRequest);
            myContext.SaveChanges();
            var requestID = compensationRequest.RequestID;
            return requestID;
        }
    }
}
