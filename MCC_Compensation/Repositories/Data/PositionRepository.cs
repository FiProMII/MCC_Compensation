using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class PositionRepository : GeneralRepository<MyContext, Position, int>
    {
        public PositionRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
