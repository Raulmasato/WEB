using ElectroJoule.Web.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSession(opts =>
{
    opts.IdleTimeout = TimeSpan.FromMinutes(60);
    opts.Cookie.HttpOnly = true;
    opts.Cookie.IsEssential = true;
});
builder.Services.AddHttpContextAccessor();
builder.Services.AddSingleton<ProductoService>();
builder.Services.AddScoped<CarritoService>();
builder.Services.AddScoped<MercadoPagoService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
