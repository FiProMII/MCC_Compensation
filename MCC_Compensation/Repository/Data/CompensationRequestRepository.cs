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
        private readonly DbSet<Approval> approvals;
        private readonly MyContext _myContext;
        public CompensationRequestRepository(MyContext myContext, IConfiguration configuration) : base(myContext)
        {
            _myContext = myContext;
            _configuration = configuration;
            employees = _myContext.Set<Employee>();
            accountRoles = _myContext.Set<AccountRole>();
            approvals = _myContext.Set<Approval>();
        }

        public IEnumerable<RequestListVM> RequestList(string Status, string NIK)
        {
            var departmentName = employees.Include("Position").Where(e => e.NIK == NIK).FirstOrDefault().Position.Department.DepartmentName;
            var roleName = accountRoles.Include(ar => ar.Account).Where(ar => ar.NIK == NIK).Select(ar => ar.Role.RoleName).ToList();
            var _crRepository = new GeneralDapperRepository<RequestListVM>(_configuration);

            if (roleName.Count > 0)
            {
                if (roleName.Contains("Employee"))
                {
                    var SPName = "SP_RetrieveRequestListByNIK";
                    _parameters.Add("@Status", Status);
                    _parameters.Add("@DepartmentName", departmentName);
                    _parameters.Add("@NIK", NIK);
                    var result = _crRepository.MultipleGet(SPName, _parameters);
                    return result;
                }
                else
                {
                    var SPName = "SP_RetrieveRequestList";
                    _parameters.Add("@Status", Status);
                    _parameters.Add("@DepartmentName", departmentName);
                    var result = _crRepository.MultipleGet(SPName, _parameters);
                    return result;
                }
            }
            else
            {
                return null;
            }
        }

        public string GetManagerEmail(string nik)
        {
            string email = null;
            var employee = employees.Where(e => e.NIK == nik).SingleOrDefault();
            email = employees.Where(e => e.NIK == employee.ManagerNIK).SingleOrDefault().Email;
            return email;
        }

        public IEnumerable<CompensationRequest> GetRequestsByDepartment(string nik)
        {
            var departmentID = employees.Include("Position").Where(e => e.NIK == nik).FirstOrDefault().Position.DepartmentID;
            var requestList = approvals.Include("CompensationRequest").Where(a => a.DepartmentID == departmentID).Select(a => a.CompensationRequest);
            return requestList.ToList();
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
