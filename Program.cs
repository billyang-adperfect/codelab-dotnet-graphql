var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add GraphQL
builder.Services.AddGraphQLServer()
    .AddQueryType<GqlTypes.QueryType>();
//builder.Services.AddGraphQLServer()
//    .AddQueryType<ad_cas_endpoint.GqlTypes.QueryType>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapGet("/health", () => "OK");
app.MapGet("/hello", () => "Hello World!");

// GraphQL
app.MapGraphQL();

app.MapControllers();

app.Run();
