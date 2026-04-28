using UserManagementAPI.Middleware;
using UserManagementAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// In-memory service for assignment/demo purposes.
builder.Services.AddSingleton<IUserService, UserService>();

var app = builder.Build();

// Custom middleware: logs HTTP method, path, status code, and processing time.
app.UseMiddleware<RequestLoggingMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Built-in middleware example.
app.UseAuthorization();

app.MapControllers();

app.Run();
