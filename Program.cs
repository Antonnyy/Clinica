using ClinicaApi.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers();

var app = builder.Build();

app.UseCors();

app.UseAuthorization();

app.MapGet("/", () => Results.Ok(new
{
    productos = ClinicaData.Productos,
    categorias = ClinicaData.Categorias,
    servicios = ClinicaData.Servicios,
    medicos = ClinicaData.Medicos,
    promociones = ClinicaData.Promociones
}));

app.MapControllers();

var port = Environment.GetEnvironmentVariable("PORT") ?? Environment.GetEnvironmentVariable("Port") ?? "10000";
app.Run($"http://0.0.0.0:{port}");



