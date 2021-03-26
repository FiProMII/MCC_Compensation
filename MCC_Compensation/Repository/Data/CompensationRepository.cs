using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Data
{
    public class CompensationRepository : GeneralRepository<MyContext, Compensation, int>
    {
        public CompensationRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
