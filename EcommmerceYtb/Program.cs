using Ecommerce.Data;
using EcommmerceYtb.Repository.Class;
using EcommmerceYtb.Repository.Interface;
using EcommmerceYtb.Service.Class;
using EcommmerceYtb.Service.Interface;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<DataContext>(opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("db")));
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IUsuarioRepository, UsuariosRepository>();
builder.Services.AddTransient<IUsuarioService, UsuarioService>();


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
