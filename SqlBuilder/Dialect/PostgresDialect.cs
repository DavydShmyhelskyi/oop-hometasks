using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Dialect;

public class PostgresDialect : ISqlDialect
{
    public string ApplySelect(string sql, int? take)
    {
        return take.HasValue
            ? $"{sql} LIMIT {take.Value}"
            : sql;
    }

    public string ApplyOrderBy(string sql, IEnumerable<string> columns)
    {
        return columns.Any()
            ? $"{sql} ORDER BY {string.Join(", ", columns)}"
            : sql;
    }
}

