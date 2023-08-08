
using backend.Data;
using backend.Models;
using backend.Repositorio;
using backend.Repositorio.Interface;
using Microsoft.EntityFrameworkCore;




namespace backend
{
  public class Program
  {
  

    public static void Main(string[] args)
    {
      var builder = WebApplication.CreateBuilder(args);

      // Add services to the container.

      builder.Services.AddControllers();
      // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
      builder.Services.AddEndpointsApiExplorer();
      builder.Services.AddSwaggerGen();
      builder.Services.AddEntityFrameworkSqlServer().AddDbContext<DataContext>(options =>
      {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"));
      });

      builder.Services.AddCors();

      builder.Services.AddScoped<iUsuario, UsuarioRepositorio>();

      var app = builder.Build();

     

      // Configure the HTTP request pipeline.
      if (app.Environment.IsDevelopment())
      {
        app.UseSwagger();
        app.UseSwaggerUI();
      }

      app.UseHttpsRedirection();

      app.UseCors(c =>
      {
        c.AllowAnyHeader();
        c.AllowAnyMethod();
        c.WithOrigins("http://localhost:4200");
      });

      app.UseAuthorization();


      app.MapControllers();

      app.Run();
    }
  }
}
