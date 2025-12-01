using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Dialect;

public interface ISqlDialect
{
    string ApplySelect(string sql, int? take);
    string ApplyOrderBy(string sql, IEnumerable<string> columns);
}

