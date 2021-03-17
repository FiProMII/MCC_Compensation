using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Interface
{
    public interface IDapperRepository<Entity> where Entity : class
    {
        Entity SingleGet(string query, DynamicParameters parameters);
        IEnumerable<Entity> MultipleGet(string query, DynamicParameters parameters);
    }
}
