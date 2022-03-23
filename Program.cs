using Npgsql;
using Moonrakers_Project.Seeds;

var builder = WebApplication.CreateBuilder(args);

var cs = builder.Configuration["LocalPostgreSQL:ConnectionString"];

using var con = new NpgsqlConnection(cs);
con.Open();

using var cmd = new NpgsqlCommand();

MoonRakersSeed.SeedMoonrakersDB(con, cmd, cs);

