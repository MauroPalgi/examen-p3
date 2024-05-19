using CasoUso.InterfasesCU;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBajaProducto, ObtenerMantenimientoPorId>();



var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true).Build();
string miConexion = configuration.GetConnectionString("Default");


//AHORA CON EL STRING DE CONEXION CONFIGURAMOS EL CONTEXTO DE EF:
builder.Services.AddDbContext<PreparacionExamen>(options =>
                                                options.UseSqlServer(miConexion));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
