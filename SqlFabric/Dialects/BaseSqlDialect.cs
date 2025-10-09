using System.Collections.Generic;
using SqlFabric.Interfaces;

namespace SqlFabric.Dialects
{
    public abstract class BaseSqlDialect : ISqlDialect
    {
        public virtual string Select(List<string> columns)
        {
            var cols = string.Join(", ", columns);
            return $"\nSELECT {cols}";
        }
        public virtual string From(string table) => $"\nFROM {table}";
        public virtual string Where(string condition) => $"\nWHERE {condition}";
        public virtual string OrderBy(string column, bool ascending) => $"\nORDER BY {column} {(ascending ? "ASC" : "DESC")}";
        public virtual string Limit(int limit) => $"\nLIMIT {limit}";
        public virtual string Offset(int offset) => $"\nOFFSET {offset}";

        public virtual string TerminateQuery(string sql)
        {
            sql = sql.Trim();
            if (!sql.EndsWith(";"))
                sql += ";";
            return sql;
        }
    }
}
