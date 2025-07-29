using avantrio.app.repositories;
using avantrio.app.services.contracts;
using avantrio.app.services.implementations;
using avantrio.infrastructure.repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// TODO: add the following services in their own projects specific IOC containers => write extension methods
builder.Services.AddScoped<IProductsService, ProductsService>();
builder.Services.AddScoped<IShoppingCartService, ShoppingCartService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();

builder.Services.AddControllers();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();
app.MapControllers();

app.Run();

