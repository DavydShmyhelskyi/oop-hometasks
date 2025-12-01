using SqlBuilder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Nodes;

public class OrderByNode<T> : ISqlNode
{
    private readonly string _column;

    public OrderByNode(Expression<Func<T, object>> selector)
    {
        _column = Extract(selector);
    }

    public void Apply(SqlBuilderContext context)
    {
        context.OrderByColumns.Add(_column + " ASC");
    }

    private static string Extract(Expression<Func<T, object>> exp)
    {
        return exp.Body switch
        {
            MemberExpression m => m.Member.Name,

            UnaryExpression u when u.Operand is MemberExpression m => m.Member.Name,
            _ => throw new InvalidOperationException("Invalid expression")
        };
    }
}

