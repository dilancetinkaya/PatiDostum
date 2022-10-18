using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PatiDostum.Application.Services;
using PatiDostum.Core.Context;
using PatiDostum.Core.Entities;
using PatiDostum.Core.IRepositories;
using PatiDostum.Infrastructure.IServices;
using PatiDostum.Infrastructure.Repositories;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddAutoMapper(typeof(PatiDostum.Application.Map.MapProfile));
builder.Services.AddDbContext<ApplicationDbContext>(
options => options.UseNpgsql("name=ConnectionStrings:DefaultConnection", b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
builder.Services.AddIdentity<UserEntity, IdentityRole>()
  .AddEntityFrameworkStores<ApplicationDbContext>()
  .AddDefaultTokenProviders();
builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings.
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;


});
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new
        SymmetricSecurityKey
        (Encoding.UTF8.GetBytes
        (builder.Configuration["Jwt:Key"]))
    };

});
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ISpeciesRepository, SpeciesRepository>();
builder.Services.AddScoped<IImageRepository, ImageRepository>();
builder.Services.AddScoped<IReportRepository, ReportRepository>();
builder.Services.AddScoped<IMessageRepository, MessageRepository>();
builder.Services.AddScoped<INeighborhoodRepository, NeighborhoodRepository>();
builder.Services.AddScoped<IProvinceRepository, ProvinceRepository>();
builder.Services.AddScoped<IDistrictRepository, DistrictRepository>();
builder.Services.AddScoped<IAdKindRepository, AdKindRepository>();
builder.Services.AddScoped<IAdvertRepository, AdvertRepository>();
builder.Services.AddScoped<IAnimalRepository, AnimalRepository>();
builder.Services.AddScoped<IBreedRepository, BreedRepository>();
builder.Services.AddScoped<IAddressRepository, AddressRepository>();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ISpeciesService, SpeciesService>();
builder.Services.AddScoped<IImageService, ImageService>();
builder.Services.AddScoped<IReportService, ReportService>();
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddScoped<INeighborhoodService, NeighborhoodService>();
builder.Services.AddScoped<IProvinceService, ProvinceService>();
builder.Services.AddScoped<IDistrictService, DistrictService>();
builder.Services.AddScoped<IAdKindService, AdKindService>();
builder.Services.AddScoped<IAdvertService, AdvertService>();
builder.Services.AddScoped<IAnimalService, AnimalService>();
builder.Services.AddScoped<IBreedService, BreedService>();
builder.Services.AddScoped<IAddressService, AddressService>();


builder.Services.AddScoped<UserManager<UserEntity>>();
builder.Services.AddScoped<SignInManager<UserEntity>>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

    var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
