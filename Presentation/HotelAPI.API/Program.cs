using HotelAPI.Application;
using HotelAPI.Domain.Entities;
using HotelAPI.Infrastructure;
using HotelAPI.Persistence;
using HotelAPI.Persistence.AppDbContext;
using Microsoft.AspNetCore.Identity;




var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<HotelAppContext>(options =>
//            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddApplication(builder.Configuration);
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddIdentity<HotelUser, HotelUserRole>(options =>
{
    options.Password.RequiredLength = 5; // минимальная длина пароля
    options.Password.RequireNonAlphanumeric = false;  // требуются ли не алфавитно-цифровые символы
    options.Password.RequireLowercase = false; // требуются ли символы в нижнем регистре
    options.Password.RequireUppercase = false;// требуются ли символы в верхнем регистре
                                              //options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1d);
    options.Password.RequireDigit = false; // требуются ли цифры
    options.Lockout.MaxFailedAccessAttempts = 5; // попытка блока
}).AddEntityFrameworkStores<HotelAppContext>().AddDefaultTokenProviders();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
