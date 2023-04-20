using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Refit;
using Whatsapp.ApiConsumer.HeaderHandler;
using Whatsapp.ApiConsumer.Identity;
using Whatsapp.Identity;
using WhatsappScrapper.Bussiness.ChromiumFileStorage;
using WhatsappScrapper.Bussiness.ClientNotifier;
using WhatsappScrapper.Bussiness.Configuration;
using WhatsappScrapper.Bussiness.FileStorage;
using WhatsappScrapper.Bussiness.ImageProcessor;
using WhatsappScrapper.Bussiness.Puppeteer;
using WhatsappScrapper.DataAccess.Context;
using WhatsappScrapper.DataAccess.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton(() => {
    new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
});

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

builder.Services.AddTransient<AuthHeaderHandle>();

builder.Services.AddRefitClient<IIdentityConsumer>()
     .ConfigureHttpClient(c => c.BaseAddress = new Uri(builder.Configuration["Authority"])).AddHttpMessageHandler<AuthHeaderHandle>();

builder.Services.AddSignalR();

builder.Services.AddDbContext<WhatsappDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Whatsappdb")));
builder.Services.AddTransient<INumberRegistrationRepository, NumberRegistrationRepository>();


var app = builder.Build();

/*Migration*/
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetService<WhatsappDBContext>();
    dbContext.Database.Migrate();
}
/*Migration End*/


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
