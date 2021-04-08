﻿using API.Context;
using API.Models;
using API.Repository;
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
    public class ApprovalRepository : GeneralRepository<MyContext, Approval, int>
    {
        public IConfiguration _configuration;
        readonly DynamicParameters _parameters = new DynamicParameters();
        private readonly MyContext _myContext;
        private readonly DbSet<Employee> employees;
        private readonly DbSet<Department> departments;
        private readonly DbSet<Status> statuses;
        public ApprovalRepository(MyContext myContext, IConfiguration configutarion) : base(myContext)
        {
            _configuration = configutarion;
            _myContext = myContext;
            employees = _myContext.Set<Employee>();
            departments = _myContext.Set<Department>();
            statuses = _myContext.Set<Status>();
        }

        public IEnumerable<RequestStatusVM> ApprovalStatus(int RequestID)
        {
            var _crRepository = new GeneralDapperRepository<RequestStatusVM>(_configuration);

            var SPName = "SP_RetrieveApprovalStatus";
            _parameters.Add("@RequestID", RequestID);
            var result = _crRepository.MultipleGet(SPName, _parameters);
            return result;
        }

        public int UpdateApprovalStatus(UpdateStatusVM updateStatusVM)
        {
            var departmentID = employees.Include("Position")
                                .Where(e => e.NIK == updateStatusVM.NIK)
                                .FirstOrDefault().Position.DepartmentID;

            var _crRepository = new GeneralDapperRepository<RequestStatusVM>(_configuration);
            var SPName = "SP_UpdateStatus";
            _parameters.Add("@RequestID", updateStatusVM.RequestID);
            _parameters.Add("@DepartmentID", departmentID);
            _parameters.Add("@StatusName", updateStatusVM.StatusName);
            _parameters.Add("@NIK", updateStatusVM.NIK);
            var result = _crRepository.Execute(SPName, _parameters);
            return result;
        }

        public IEnumerable<string> GetRecipientEmails(int type, string nik)
        {
            IEnumerable<string> emails = Enumerable.Empty<string>();
            switch (type)
            {
                case 1:
                    var HRID = departments.Where(d => d.DepartmentName == "HR").Select(d => d.DepartmentID).FirstOrDefault();
                    emails = employees.Include("Position")
                        .Where(e => e.Position.DepartmentID == HRID)
                        .Select(e => e.Email);
                    break;
                case 2:
                    var FinanceID = departments.Where(d => d.DepartmentName == "Finance").Select(d => d.DepartmentID).FirstOrDefault();
                    emails = employees.Include("Position")
                        .Where(e => e.Position.DepartmentID == FinanceID)
                        .Select(e => e.Email);
                    break;
            }
            return emails.AsList();
        }
    }
}
