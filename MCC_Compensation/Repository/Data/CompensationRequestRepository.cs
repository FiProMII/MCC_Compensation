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
    public class CompensationRequestRepository : GeneralRepository<MyContext, CompensationRequest, int>
    {
        public IConfiguration _configuration;
        readonly DynamicParameters _parameters = new DynamicParameters();
        public CompensationRequestRepository(MyContext myContext, IConfiguration configuration) : base(myContext)
        {
            _configuration = configuration;
        }

        public IEnumerable<RequestListVM> RequestList(string Status)
        {
            var _crRepository = new GeneralDapperRepository<RequestListVM>(_configuration);

            var SPName = "SP_RetrieveDataStatus";
            _parameters.Add("@Status", Status);
            var result = _crRepository.MultipleGet(SPName, _parameters);
            return result;
        }
    }
}
