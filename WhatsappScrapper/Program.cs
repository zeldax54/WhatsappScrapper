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
    options.AddPolicy("AllowAllOrigins", builder =>
    {
        builder.WithOrigins("http://localhost:4200");
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
        builder.AllowCredentials();
    });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IChromiumFileManager, ChromiumFileManager>();
builder.Services.AddTransient<IWhatsappConfiguration, WhatsappConfiguration>();
builder.Services.AddTransient<IWPuppeteer, WPuppeteer>();
builder.Services.AddTransient<IImageProcessor, ImageProcessor>();


builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAllOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHub<Notifier>("/notifier");


app.Run();
