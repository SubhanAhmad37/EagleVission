using EagleVission.Data;
using EagleVission.Interfaces;
using EagleVission.Repositories;
using EagleVission.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// ✅ Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// =====================
// DATABASE (ONLY ONCE)
// =====================
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

// =====================
// CONTROLLERS
// =====================
builder.Services.AddControllers();

// =====================    
// SWAGGER
// =====================
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ✅ Use CORS (IMPORTANT: before MapControllers)
app.UseCors("AllowAll");

// =====================
// PIPELINE
// =====================
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.RoutePrefix = "swagger";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();