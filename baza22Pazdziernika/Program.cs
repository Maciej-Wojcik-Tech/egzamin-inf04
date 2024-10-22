using baza.Data; // Upewnij siê, ¿e to jest poprawna przestrzeñ nazw

var builder = WebApplication.CreateBuilder(args);

// Dodanie kontekstu bazy danych
builder.Services.AddDbContext<SamochodContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Dodanie kontrolerów i widoków
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Konfiguracja potoku ¿¹dañ HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // Domyœlna wartoœæ HSTS to 30 dni. Mo¿esz chcieæ to zmieniæ w przypadku scenariuszy produkcyjnych.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Mapowanie tras
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
