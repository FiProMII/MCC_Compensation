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

        public IEnumerable<RequestVM> Request()
        {
            var _requestRepository = new GeneralDapperRepository<RequestVM>(_configuration);

            var result = _requestRepository.MultipleGet("SP_RetrieveRequest", null);
            return result;
        }
    }
}
