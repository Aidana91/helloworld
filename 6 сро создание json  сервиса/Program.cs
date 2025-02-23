//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();
//app.MapGet("/hello", () => new { message = "Hello, World!" });
//app.Run();

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapGet("/hello", () => new { message = "Hello,dear friend! and bestfriend!" });
app.MapGet("/sum", () => new { result = 7 + 3 });
app.MapGet("/sum2", () => new { result = 20 - 4});
app.Run();