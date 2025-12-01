using SqlBuilder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Nodes;

public class SelectNode : ISqlNode
{
    private readonly Type _type;

    public SelectNode(Type type)
    {
        _type = type;
    }

    public void Apply(SqlBuilderContext context)
    {
        context.EntityType = _type;
    }
}

