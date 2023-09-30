global using LinqToDB;
global using LinqToDB.Data;
global using LinqToDB.AspNet;
global using STEMWars.Server.Services.DbAccess;
global using STEMWars.Shared.Models.Data;
global using STEMWars.Shared.Models.DataTransferObjects;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using STEMWars.Server.Utils.ServiceRegistration;
using System.Text;
using LinqToDB.AspNet.Logging;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddLinqToDBContext<AppDataConnection>((provider, options) =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

    return options
        .UseSqlServer(connectionString)
        .UseDefaultLogging(provider);
});
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddSTEMWarsServices();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new()
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("AppSettings:Token").Value)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });
builder.Services.AddHttpContextAccessor();

var app = builder.Build();

app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();

app.UseRouting();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();

app.Run();
