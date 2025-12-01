using SqlBuilder;
using SqlBuilder.Dialect;

var query1 = SqlBuilder.Builder.SqlBuilder
    .Select<User>(new PostgresDialect())
    .OrderBy(_ => _.RegistrationDate)
    .Take(10)
    .Build();

Console.WriteLine(query1.CommandText);
Console.WriteLine();

var query2 = SqlBuilder.Builder.SqlBuilder
    .Select<User>(new SqlServerDialect())
    .OrderBy(_ => _.RegistrationDate)
    .Take(10)
    .Build();
Console.WriteLine(query2.CommandText);