using Microsoft.EntityFrameworkCore;
using Web;
using Web.Services;
using Web.Services.IShortnerService;
using Web.Static_Data;

var builder = WebApplication.CreateBuilder(args);

var config = new ConfigurationManager();
// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
sqlServerOptionsAction: sqlOptions =>
{
    sqlOptions.EnableRetryOnFailure(
        maxRetryCount: 10,
        maxRetryDelay: TimeSpan.FromSeconds(30),
        errorNumbersToAdd: null);
})
);

builder.Services.AddHttpClient<ILinkService, LinkService>();
builder.Services.AddScoped<IBaseService, BaseService>();
builder.Services.AddScoped<ILinkService, LinkService>();
SD.ApiBase = config["ServiceUrls:LinkShortner"];

var app = builder.Build();





// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
//app.MapControllers();

app.Run();
