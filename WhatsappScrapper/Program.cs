using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using Whatsapp.ApiConsumer.Identity;
using Whatsapp.Identity;
using WhatsappScrapper.Bussiness.ChromiumFileStorage;
using WhatsappScrapper.Bussiness.ClientNotifier;
using WhatsappScrapper.Bussiness.Configuration;
using WhatsappScrapper.Bussiness.FileStorage;
using WhatsappScrapper.Bussiness.ImageProcessor;
using WhatsappScrapper.Bussiness.Puppeteer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificAdminOrigins", options =>
    {
        options.WithOrigins(builder.Configuration["CORSAdminSource"]);
        options.AllowAnyHeader();
        options.AllowAnyMethod();
        options.AllowCredentials();
    });
});
builder.Services.AddHttpContextAccessor();

builder.Services.AddAuthentication(options => options.DefaultAuthenticateScheme = "Local")
       .AddScheme<AuthenticationSchemeOptions, LocalAuthenticationHandler>("Local", null);

builder.Services.AddAuthorization(options =>
{    
    options.AddPolicy("AdminResource", policy =>
    {           
        policy.Requirements.Add(new AdminRoleRequirement());
    });
});

builder.Services.AddSingleton<IAuthorizationHandler, AdminRoleRequirementHandler>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IChromiumFileManager, ChromiumFileManager>();
builder.Services.AddTransient<IWhatsappConfiguration, WhatsappConfiguration>();
builder.Services.AddTransient<IWPuppeteer, WPuppeteer>();
builder.Services.AddTransient<IImageProcessor, ImageProcessor>();

builder.Services.AddRefitClient<IIdentityConsumer>().ConfigureHttpClient(c => {

    c.BaseAddress = new Uri(builder.Configuration["Authority"]); 
});

builder.Services.AddSignalR();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowSpecificAdminOrigins");

app.UseAuthentication();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHub<Notifier>("/notifier");


app.Run();
