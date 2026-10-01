using Full_Stack_Grad_Project.Data;
using Full_Stack_Grad_Project.Middleware;
using Full_Stack_Grad_Project.Model;
using Full_Stack_Grad_Project.Repo;
using Full_Stack_Grad_Project.Repo.Interfaces;
using Full_Stack_Grad_Project.Services;
using Full_Stack_Grad_Project.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddScoped<ICourseRepo, CourseRepo>();
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<ICmsRepo, CmsRepo>();
builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
builder.Services.AddScoped<IHomepageService, HomepageService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});


builder.Services.AddCors(options =>
{
    options.AddPolicy("ReactDev", policy =>
        policy.WithOrigins("http://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseMiddleware<GlobalException>();

app.UseHttpsRedirection();

app.UseCors("ReactDev");

app.UseAuthorization();

app.MapControllers();

app.Run();
