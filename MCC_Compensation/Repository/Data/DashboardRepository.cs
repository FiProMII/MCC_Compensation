using API.Context;
using API.ViewModels;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Data 
{
    public class DashboardRepository : GeneralDapperRepository<ChartVM>
    { 
        public IConfiguration _configuration;
        readonly DynamicParameters _parameters = new DynamicParameters();
        public DashboardRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<ChartVM> Chart(string Params)
        {
            var _dashboardRepository = new GeneralDapperRepository<ChartVM>(_configuration);
            _parameters.Add("@Params", Params);
            var result = _dashboardRepository.MultipleGet("SP_RetrieveChart", _parameters);
            return result;
        }
    }
}
