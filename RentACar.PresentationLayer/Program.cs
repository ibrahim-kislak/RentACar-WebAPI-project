using RentACarProject.BusinessLayer.Abstract;
using RentACarProject.BusinessLayer.Concrete;
using RentACarProject.DataAccessLayer.Abstract;

using RentACarProject.DataAccessLayer.EntityFramework;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IOrderDal, EfOrderDal>(); // Veri eriþim katmaný için
builder.Services.AddScoped<IOrderService, OrderManager>();
// Program.cs içerisine her yeni modül için bunlarý eklemelisin:
builder.Services.AddScoped<ICarDal, EfCarDal>();
builder.Services.AddScoped<ICarService, CarManager>();

builder.Services.AddScoped<ICustomerDal, EfCustomerDal>();
builder.Services.AddScoped<ICustomerService, CustomerManager>();
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
