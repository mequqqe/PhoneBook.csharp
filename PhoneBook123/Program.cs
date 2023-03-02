using PhoneBook.Api.Repositories;
using PhoneBook.Api.Services;
using System.Data;
using System.Data.SqlClient;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPhoneBookRepository>(_ =>
 new PhoneBookRepository(builder.Configuration
.GetConnectionString("ConnectionString")));
builder.Services.AddScoped<IPhoneBookService, PhoneBookService>();
builder.Configuration.GetConnectionString("ConnectionString");

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
