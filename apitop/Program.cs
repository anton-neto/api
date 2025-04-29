var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/sobre", () => "Cuzin seu");

app.MapGet("/terceira", () => "Cuzin meu");

app.MapGet("/quarta", () => "puts");

app.MapGet("data", () => $"Acorda fi, ja é: {DateTime.Now.ToString("dd:MM:yyyy")}");

app.Run();
