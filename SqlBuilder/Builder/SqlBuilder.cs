using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlBuilder.Dialect;

namespace SqlBuilder.Builder;

public static class SqlBuilder
{
    public static SqlBuilder<T> Select<T>(ISqlDialect? dialect = null)
        => new SqlBuilder<T>(dialect ?? new PostgresDialect());
}

