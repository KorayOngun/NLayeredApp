using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// bir sepete newLenen nesnelere atýlýyor  kullanýlmasý gereken yere çaðrýlýyor
// böylece bütün uygulama boyunca bu nesnelerein tekrar newlenmesine gerek 
// kalmýyor. 
// builder.services.AddSingleton< <kullanýlmasýGerekenYer> , <newLenenNesne> >();
builder.Services.AddSingleton<IProductService,ProductManager>();
builder.Services.AddSingleton<IProductDal,EfProductDal>(); 



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
