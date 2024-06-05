var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


List<IdentityServer4.Models.Client> clients = [new IdentityServer4.Models.Client {
    ClientId = "ClientID",
    ClientName = "dinhphu951998"
}];

List<IdentityServer4.Models.ApiScope> scopes = [new IdentityServer4.Models.ApiScope {
    Name = "moviesAPI",
}];

builder.Services.AddIdentityServer()
                .AddInMemoryClients(clients)
                .AddInMemoryApiScopes(scopes);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

