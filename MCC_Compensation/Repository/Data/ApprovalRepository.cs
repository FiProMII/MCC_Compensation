using API.Context;
using API.Models;
using API.Repository;
using API.ViewModels;
using Dapper;
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
        public ApprovalRepository(MyContext myContext, IConfiguration configutarion) : base(myContext)
        {
            _configuration = configutarion;
        }

        public IEnumerable<RequestStatusVM> ApprovalStatus(int RequestID)
        {
            var _crRepository = new GeneralDapperRepository<RequestStatusVM>(_configuration);

            var SPName = "SP_RetrieveApprovalStatus";
            _parameters.Add("@RequestID", RequestID);
            var result = _crRepository.MultipleGet(SPName, _parameters);
            return result;
        }
    }
}
