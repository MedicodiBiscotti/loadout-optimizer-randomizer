using LoadoutOptimizerRandomizer.Core.Redout.Services;
using LoadoutOptimizerRandomizer.Model.Redout.Mapping;
using LoadoutOptimizerRandomizer.Repository.Redout.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IShipComponentService, ShipComponentService>();
builder.Services.AddScoped<IComponentRepository, InMemoryComponentRepository>();

// AutoMapper
builder.Services.AddAutoMapper(typeof(EntityDtoProfile));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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