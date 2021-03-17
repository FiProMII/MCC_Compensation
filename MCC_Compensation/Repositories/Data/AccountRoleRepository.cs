using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class AccountRoleRepository : GeneralRepository<MyContext, AccountRole, (string, int)>
    {
        public AccountRoleRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
