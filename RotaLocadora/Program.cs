using RotaLocadora.DataContext;
using Microsoft.EntityFrameworkCore;
using RotaLocadora.Service.UsuariosService;
using RotaLocadora.Service.CarsService;
using RotaLocadora.Service.HistoryService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<IUsuariosInterface, UsuariosService>();
//builder.Services.AddScoped<ICarsInterface, CarsService>();
//builder.Services.AddScoped<IHistoryInterface, HistoryService>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
}
            );

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
