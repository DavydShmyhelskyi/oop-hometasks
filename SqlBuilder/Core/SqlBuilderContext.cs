using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Core;

public class SqlBuilderContext
{
    public required Type EntityType { get; set; }
    public List<string> OrderByColumns { get; } = new();
    public int? Take { get; set; }
}

