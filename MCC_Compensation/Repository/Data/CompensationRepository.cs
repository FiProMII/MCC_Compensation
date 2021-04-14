using API.Context;
using API.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Data
{
    public class CompensationRepository : GeneralRepository<MyContext, Compensation, int>
    {
        public IConfiguration _configuration;
        public CompensationRepository(MyContext myContext, IConfiguration configuration) : base(myContext)
        {
            _configuration = configuration;
        }

        public IEnumerable<Compensation> GetList()
        {
            var _compensationRepository = new GeneralDapperRepository<Compensation>(_configuration);
            var SPName = "SP_RetrieveCompensation";
            var result = _compensationRepository.MultipleGet(SPName, null);
            return result;
        }
    }
}
