using API.Context;
using API.Models;
using API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Data
{
    public class ApprovalRepository : GeneralRepository<MyContext, Approval, int>
    {
        public ApprovalRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
