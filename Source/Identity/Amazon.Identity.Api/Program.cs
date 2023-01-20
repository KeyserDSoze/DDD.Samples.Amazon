using Amazon.Identity.Domain;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddUserStorage();
builder.Services.AddUserManager();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/identity/createuser", ([FromServices] IAppUserManager userManager) =>
{
    return userManager.CreateNew(new AppUser { Username = "dadsa" });
})
.WithName("Identity")
.WithOpenApi();

app.Run();