using API.ViewModels;
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
        public DashboardRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<ChartVM> Chart()
        {
            var _dashboardRepository = new GeneralDapperRepository<ChartVM>(_configuration);

            var result = _dashboardRepository.MultipleGet("SP_RetrieveCompensation", null);
            return result;
        }
    }
}
