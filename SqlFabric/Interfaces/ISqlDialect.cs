namespace SqlFabric.Interfaces
{
    public interface ISqlDialect
    {
        string Select(List<string> columns);
        string From(string table);
        string Where(string condition);
        string OrderBy(string column, bool ascending);
        string Limit(int limit);
        string Offset(int offset);
        string TerminateQuery(string sql);
    }
}
