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
Controller: Kullan�c�dan gelen HTTP isteklerini i�leyen ve uygun bir yan�t d�nd�ren s�n�flard�r.
Action: Bir Controller i�inde tan�mlanan, belirli bir iste�i i�leyen metotlard�r.
Model: Veri yap�s�n� ve i� mant���n� temsil eden s�n�flard�r.
View: Kullan�c�ya g�sterilecek aray�z� temsil eder. Razor View Engine kullan�larak dinamik HTML olu�turulabilir.
Razor: .cshtml dosyalar�nda kullan�lan, C# kodlar�n� HTML i�ine g�mmek i�in kullan�lan bir s�zdizimidir.
RazorView: Razor kullan�larak olu�turulan view'leri ifade eder.
wwwroot: CSS, JS, resim gibi statik dosyalar�n tutuldu�u klas�rd�r.
builder.Build(): Uygulaman�n servislerini yap�land�r�r ve �al��t�r�lmaya haz�r hale getirir.
app.Run(): Uygulamay� ba�lat�r ve gelen HTTP isteklerini i�ler.
*/