using Microsoft.EntityFrameworkCore;
using Sistema_de_Filas.Data;
using Sistema_de_Filas.Data.Repositories;
using Sistema_de_Filas.Data.Repositories.Interfaces;
using Sistema_de_Filas.Services;
using Sistema_de_Filas.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddScoped<IFilaRepo, FilaRepo>();
builder.Services.AddScoped<IUsuarioRepo, UsuarioRepo>();
builder.Services.AddScoped<ISenhaRepo, SenhaRepo>();

builder.Services.AddScoped<IFilaService, FilaService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<ISenhaService, SenhaService>();


builder.Services.AddControllers();

builder.Services.AddSwaggerGen();//Adicionando o swagger a nossa aplicacao

builder.Services.AddDbContext<DataContext>(options =>
         options.UseSqlite("Data source=sistema-filas.db"));




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //Codigos para utilizar o swagger
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
