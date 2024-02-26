using WMS.Adapter.Queue.ServiceRegistration;
using WMS.Adapter.SQL.ServiceRegistration;
using WMS.Core.ServiceRegistration;


//this should be taken out of adapter.api in order to not reference all other adapters
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RegisterCore();
builder.Services.RegisterAdapterQueue();
builder.Services.RegisterAdapterSql();

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
