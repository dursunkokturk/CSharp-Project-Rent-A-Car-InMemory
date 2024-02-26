using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// IOC Kullanilarak Web Uzerinden Giden Istek Ile Database Arasindaki Iletisimi Kurmak Gerekiyor
// Dependency Injection Olarak Sisteme Dahil Edilen Kisim Uzerinden 
// BrandManager Class ini Calistiriyoruz
builder.Services.AddSingleton<IBrandService,BrandManager>();

builder.Services.AddSingleton<IBrandDal, BrandDal>();

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
