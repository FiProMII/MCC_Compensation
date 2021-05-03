using API.Context;
using API.Models;
using API.ViewModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Data
{
    public class PositionRepository : GeneralRepository<MyContext, Position, int>
    {
        public IConfiguration _configuration;
        public PositionRepository(MyContext myContext, IConfiguration configuration) : base(myContext)
        {
            _configuration = configuration;
        }

        public IEnumerable<PositionListVM> GetList()
        {
            var _employeeRepository = new GeneralDapperRepository<PositionListVM>(_configuration);
            var SPName = "SP_RetrievePosition";
            var result = _employeeRepository.MultipleGet(SPName, null);
            return result;
        }
    }
}
