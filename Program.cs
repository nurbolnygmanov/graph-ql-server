using graph_ql_server.GraphQL;

var builder = WebApplication.CreateBuilder(args);

ConfigureServices(builder.Services);

var app = builder.Build();

app.UseAuthentication();
app.MapGraphQL();

app.Run();


void ConfigureServices(IServiceCollection services)
{
    services.AddGraphQLServer().AddQueryType<Query>().AddType<BookType>();
    services.AddAuthentication();
}