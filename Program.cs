using MiniChallengeTwo2Four.Services.addingNumbers;
using MiniChallengeTwo2Four.Services.addingStrings;
using MiniChallengeTwo2Four.Services.HigherOrLower;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IHigherOrLowerService, HigherOrLowerService>();
builder.Services.AddScoped<IaddingNumbersService, addingNumbersService>();
builder.Services.AddScoped<IaddingStringsService, addingStringsService>();

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
