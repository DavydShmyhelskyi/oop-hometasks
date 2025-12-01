using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Core;

public class SqlQuery
{
    public string CommandText { get; }
    public IReadOnlyDictionary<string, object> Parameters { get; }

    public SqlQuery(string sql, Dictionary<string, object> parameters)
    {
        CommandText = sql;
        Parameters = parameters;
    }
}

