using HotelAPI.API;
using HotelAPI.Application;
using HotelAPI.Application.Identity.Concrete;
using HotelAPI.Domain.Entities;
using HotelAPI.Infrastructure;
using HotelAPI.Persistence;
using HotelAPI.Persistence.AppDbContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;




var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<HotelAppContext>(options =>
//            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.Configure<JWTOptions>(builder.Configuration.GetSection("JWTOptions"));
JWTOptions jwtSettings = builder.Configuration.GetSection("JWTOptions").Get<JWTOptions>();

builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddApplication(builder.Configuration);
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddSwaggerSetting();
builder.Services.AuthenticationJwtSettings(jwtSettings);



//builder.Services.AddSwaggerGen(option =>
//{
//    option.SwaggerDoc("v1", new OpenApiInfo { Title = "Demo API", Version = "v1" });
//    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
//    {
//        In = ParameterLocation.Header,
//        Description = "Please enter a valid token",
//        Name = "Authorization",
//        Type = SecuritySchemeType.Http,
//        BearerFormat = "JWT",
//        Scheme = "Bearer"
//    });
//    option.AddSecurityRequirement(new OpenApiSecurityRequirement
//    {
//        {
//            new OpenApiSecurityScheme
//            {
//                Reference = new OpenApiReference
//                {
//                    Type=ReferenceType.SecurityScheme,
//                    Id="Bearer"
//                }
//            },
//            new string[]{}
//        }
//    });
//});

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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
