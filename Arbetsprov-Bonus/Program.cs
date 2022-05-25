using Arbetsprov_Bonus.Data;
using Arbetsprov_Bonus.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<GisysDbContext>(options => options.UseInMemoryDatabase("gisys"));
builder.Services.AddScoped<IConsultantRepository, ConsultantRepository>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<GisysDbContext>();
    AddTestData(context);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
}

app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();

static void AddTestData(GisysDbContext context)
{
    var consultantOne = new Consultant("Money", "Penny", DateTime.UtcNow.AddYears(-1), 1);
    var consultantTwo = new Consultant("Gold", "Finger", DateTime.UtcNow.AddYears(-3), 2);

    context.Consultants.Add(consultantOne);
    context.Consultants.Add(consultantTwo);

    context.SaveChanges();
}