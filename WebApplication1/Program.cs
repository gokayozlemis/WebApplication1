using static System.Net.WebRequestMethods;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();


/* 
Controller: Kullanýcýdan gelen HTTP isteklerini iþleyen ve uygun bir yanýt döndüren sýnýflardýr.
Action: Bir Controller içinde tanýmlanan, belirli bir isteði iþleyen metotlardýr.
Model: Veri yapýsýný ve iþ mantýðýný temsil eden sýnýflardýr.
View: Kullanýcýya gösterilecek arayüzü temsil eder. Razor View Engine kullanýlarak dinamik HTML oluþturulabilir.
Razor: .cshtml dosyalarýnda kullanýlan, C# kodlarýný HTML içine gömmek için kullanýlan bir sözdizimidir.
RazorView: Razor kullanýlarak oluþturulan view'leri ifade eder.
wwwroot: CSS, JS, resim gibi statik dosyalarýn tutulduðu klasördür.
builder.Build(): Uygulamanýn servislerini yapýlandýrýr ve çalýþtýrýlmaya hazýr hale getirir.
app.Run(): Uygulamayý baþlatýr ve gelen HTTP isteklerini iþler.
*/