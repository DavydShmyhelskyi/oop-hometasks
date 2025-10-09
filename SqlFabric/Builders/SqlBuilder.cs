using SqlFabric.Entities;
using SqlFabric.Interfaces;
using System.Text;

namespace SqlFabric.Builders
{
    public class SqlBuilder
    {
        private readonly ISqlDialect dialect;
        private readonly StringBuilder sb = new();

        public SqlBuilder(ISqlDialect dialect)
        {
            this.dialect = dialect;
        }

        public SqlBuilder Columns(List<string> columns)
        {
            sb.Append(dialect.Select(columns));
            return this;
        }

        public SqlBuilder From(string table)
        {
            sb.Append(dialect.From(table));
            return this;
        }

        public SqlBuilder Where(string condition)
        {
            sb.Append(dialect.Where(condition));
            return this;
        }

        public SqlBuilder OrderBy(string column, bool ascending = true)
        {
            sb.Append(dialect.OrderBy(column, ascending));
            return this;
        }

        public SqlBuilder Limit(int limit)
        {
            sb.Append(dialect.Limit(limit));
            return this;
        }

        public SqlBuilder Offset(int offset)
        {
            sb.Append(dialect.Offset(offset));
            return this;
        }

        public SqlCommand Build()
        {
            var sql = dialect.TerminateQuery(sb.ToString());
            return new SqlCommand { Sql = sql };
        }
    }
}
