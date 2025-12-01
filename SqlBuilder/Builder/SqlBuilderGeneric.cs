using System.Linq.Expressions;
using SqlBuilder.Core;
using SqlBuilder.Dialect;
using SqlBuilder.Nodes;

namespace SqlBuilder.Builder;

public class SqlBuilder<T>
{
    private readonly ISqlDialect _dialect;
    private readonly List<ISqlNode> _nodes = new();

    public SqlBuilder(ISqlDialect dialect)
    {
        _dialect = dialect;
        _nodes.Add(new SelectNode(typeof(T)));
    }

    public SqlBuilder<T> OrderBy(Expression<Func<T, object>> selector) 
    {
        _nodes.Add(new OrderByNode<T>(selector));
        return this;
    }

    public SqlBuilder<T> Take(int count)
    {
        _nodes.Add(new TakeNode(count));
        return this;
    }

    public SqlQuery Build()
    {
        var ctx = new SqlBuilderContext
        {
            EntityType = typeof(T)
        };

        foreach (var n in _nodes)
            n.Apply(ctx);

        var baseSql = $"SELECT * FROM {ctx.EntityType.Name}";

        baseSql = _dialect.ApplySelect(baseSql, ctx.Take);
        baseSql = _dialect.ApplyOrderBy(baseSql, ctx.OrderByColumns);

        return new SqlQuery(baseSql, new Dictionary<string, object>());
    }
}
