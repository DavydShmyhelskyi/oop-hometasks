using SqlFabric.Builders;
using SqlFabric.Entities;
using SqlFabric.Interfaces;

namespace SqlFabric.Directors
{
    public class SqlDirector
    {
        public SqlCommand BuildPagedUsersQuery(ISqlDialect dialect)
        {
            return new SqlBuilder(dialect)
                .Columns(new List<string> { "id", "email", "created_at" })
                .From("users")
                .Where("lower(email) LIKE lower('%@gmail.com%')")
                .OrderBy("created_at", ascending: true)
                .Limit(10)
                .Offset(20)
                .Build();
        }
    }
}
