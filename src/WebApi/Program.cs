using Sales;
using Shipping;
using Billing;
using Microsoft.OpenApi.Models;
using Product;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSales();
builder.Services.AddShipping();
builder.Services.AddBilling();
builder.Services.AddProduct();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapSales();
app.MapShipping();
app.MapBilling();

app.UseSwagger();
app.UseSwaggerUI();
    

app.MapGet("/", () => "Hello World from the main app...");

app.UseRouting();
app.MapControllers();

app.Run();