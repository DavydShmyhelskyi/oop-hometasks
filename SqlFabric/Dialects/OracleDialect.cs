using SqlFabric.Interfaces;

namespace SqlFabric.Dialects
{
    public class OracleDialect : BaseSqlDialect
    {
        public override string Limit(int limit) => $"\nFETCH FIRST {limit} ROWS ONLY";
        public override string Offset(int offset) => $"\nOFFSET {offset} ROWS";
    }
}
