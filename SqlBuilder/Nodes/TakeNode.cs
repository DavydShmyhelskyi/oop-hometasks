using SqlBuilder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Nodes;

public class TakeNode : ISqlNode
{
    private readonly int _count;

    public TakeNode(int count)
    {
        _count = count;
    }

    public void Apply(SqlBuilderContext context)
    {
        context.Take = _count;
    }
}

