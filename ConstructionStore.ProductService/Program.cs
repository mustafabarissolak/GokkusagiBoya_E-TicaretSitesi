using ConstructionStore.ProductService.Data;
using ConstructionStore.ProductService.Repositories.Implementations;
using ConstructionStore.ProductService.Repositories.Interfaces;
using ConstructionStore.ProductService.Services.Implementations;
using ConstructionStore.ProductService.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Bağlantı dizesini kullanarak DbContext'i ekleyin
builder.Services.AddDbContext<ProductDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Dependency Injection için Repositories ve Servicec kayıtları
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IBrandRepository, BrandRepository>(); 
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>(); 

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IBrandService, BrandService>(); 
builder.Services.AddScoped<ICategoryService, CategoryService>(); 


builder.Services.AddControllers();
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
