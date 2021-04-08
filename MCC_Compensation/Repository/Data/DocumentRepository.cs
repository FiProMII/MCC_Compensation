using API.Context;
using API.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Data
{
    public class DocumentRepository : GeneralRepository<MyContext, Document, int>
    {
        public IConfiguration _configuration;
        readonly DynamicParameters _parameters = new DynamicParameters();
        public DocumentRepository(MyContext myContext, IConfiguration configuration) : base(myContext)
        {
            _configuration = configuration;
        }

        public IEnumerable<Document> GetDocument(int requestID)
        {
            var _crRepository = new GeneralDapperRepository<Document>(_configuration);
            var SPName = "SP_RetrieveDocument";
            _parameters.Add("@RequestID", requestID);
            var result = _crRepository.MultipleGet(SPName, _parameters);
            return result;
        }
    }
}
