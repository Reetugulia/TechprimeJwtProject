using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;
using Techprime.Data;
using TechprimeJwtProject.Models;
using TechprimeJwtProject.Repository;
using TechprimeJwtProject.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ITypeRepository,TypeRepository>();
builder.Services.AddScoped<IReasonRepository, ReasonRepository>();
builder.Services.AddScoped<IPriorityRepository, PriorityRepository>();
builder.Services.AddScoped <ILocationRepository, LocationRepository>();
builder.Services.AddScoped<IDivisionRepository, DivisionRepository>();
builder.Services.AddScoped <IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped <ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped <IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<ITypeServices, TypeServices>();
builder.Services.AddScoped <IReasonServices, ReasonServices>();
builder.Services.AddScoped<IPriorityServices, PriorityServices>();
builder.Services.AddScoped <ILocationServices, LocationServices>();
builder.Services.AddScoped <IDivisionServices, DivisionServices>();
builder.Services.AddScoped <IDepartmentServices, DepartmentServices>();
builder.Services.AddScoped <ICategoryServices, CategoryServices>();
builder.Services.AddScoped<IProjectServices, ProjectServices>();

builder.Services.Configure<JwtOption>(builder.Configuration.GetSection("Jwt"));
var key = builder.Configuration.GetSection("Jwt:Key").Get<string>();

builder.Services.AddAuthentication(x => { 
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options => {
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,// create token
        ValidateAudience = true, // receive the token
        ValidateLifetime = true,  // expiration policy
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))
    };
});
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins("http://localhost:4200")
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

builder.Services.AddControllers();
var constr = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(op => op.UseSqlServer(constr));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Test01", Version = "v1" });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme."

    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                          {
                              Reference = new OpenApiReference
                              {
                                  Type = ReferenceType.SecurityScheme,
                                  Id = "Bearer"
                              }
                          },
                         new string[] {}
                    }
                });
});

var app = builder.Build();



// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();
app.UseCors("AllowSpecificOrigin");
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.UseCors(options=>options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.Run();
