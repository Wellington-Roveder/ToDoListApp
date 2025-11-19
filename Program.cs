using Microsoft.EntityFrameworkCore;
using ToDoList.Data;//ajusta conforme ao namespace do seu dbContext


var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Configuration.AddUserSecrets<Program>();


//conexao com mySql
builder.Services.AddDbContext<TodoContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

//adiciona suporte aos controllers
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new DateTimeConverter());
    });

//adiciona suporte ao swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//midleware do desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}



// 🔐 HTTPS e roteamento
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
