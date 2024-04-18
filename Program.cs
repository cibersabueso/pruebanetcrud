using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configuración del logging para obtener más detalles en el desarrollo
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Agrega servicios al contenedor.
builder.Services.AddRazorPages();

// Configuración de la cadena de conexión para PostgreSQL
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Asegúrate de agregar los controladores si estás usando API Controllers
builder.Services.AddControllers();

var app = builder.Build();

// Configura el pipeline de solicitudes HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // El valor predeterminado de HSTS es de 30 días. Puedes cambiar esto para escenarios de producción, ver https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// app.UseHttpsRedirection(); // Descomenta si decides usar redirección HTTPS.
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Mapea los Razor Pages y los controladores
app.MapRazorPages();
app.MapControllers(); // Importante para asegurar que los controladores sean mapeados.

app.Run();