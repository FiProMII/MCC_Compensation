using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class DocumentRepository : GeneralRepository<MyContext, Document, int>
    {
        public DocumentRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
