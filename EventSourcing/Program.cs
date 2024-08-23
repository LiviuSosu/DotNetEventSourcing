using EventSourcing_Core.Messaging;
using EventSourcing_Core.Reporting;
using EventSourcing_Core.Utils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IReportDatabase, ReportDatabase>(); //Singleton?
//builder.Services.AddScoped<ICommandHandlerFactory, StructureMapCommandHandlerFactory>();
//builder.Services.AddTransient<ICommandBus, CommandBus>();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(BaseHandler<,>).Assembly));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
