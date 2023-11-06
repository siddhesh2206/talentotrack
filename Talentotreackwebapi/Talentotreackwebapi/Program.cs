using Microsoft.EntityFrameworkCore;
using Talentotrack.common.Repositories;
using Talentotrack.common.services;
using Talentotrack.Dao.DB;
using Talentotrack.Dao.Repositories;
using Talentotrack.services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IAccountRepository, AccountRepository>();


// Add services to the container.
builder.Services.AddDbContext<TalentotrackDbContext>(options =>
options.UseSqlServer(builder.Configuration["ConnectionStrings:Dconn"]));

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
