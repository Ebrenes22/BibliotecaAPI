using BibliotecaAPI.Datos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Services Area
builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(opciones => 
    opciones.UseSqlServer("name = DefaultConnection"));



var app = builder.Build();

//End Services Area


//Middlewares Area

app.MapControllers();

//End middlewares Area

app.Run();
