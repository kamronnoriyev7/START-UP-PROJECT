using YourNamespace.Services;

var builder = WebApplication.CreateBuilder(args);

// Bot xizmatini ro‘yxatdan o‘tkazish
builder.Services.AddSingleton<TelegramBotService>();

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Telegram bot xizmatini ishga tushirish
var botService = app.Services.GetRequiredService<TelegramBotService>();

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
