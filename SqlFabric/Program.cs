using SqlFabric.Dialects;
using SqlFabric.Directors;
using SqlFabric.Entities;
using SqlFabric.Interfaces;

ISqlDialect dialect = new PostgresDialect();
ISqlDialect mySqlDialect = new MySqlDialect();
ISqlDialect oracleDialect = new OracleDialect();
SqlDirector director = new SqlDirector();

SqlCommand command = director.BuildPagedUsersQuery(dialect);
Console.WriteLine("=== Згенерований SQL Postgres Dialect===");
Console.WriteLine($"{command.Sql}\n");

command = director.BuildPagedUsersQuery(mySqlDialect);
Console.WriteLine("=== Згенерований SQL MySQL Dialect===");
Console.WriteLine($"{command.Sql}\n");

command = director.BuildPagedUsersQuery(oracleDialect);
Console.WriteLine("=== Згенерований SQL Oracle Dialect===");
Console.WriteLine($"{command.Sql}\n");