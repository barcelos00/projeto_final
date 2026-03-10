var builder = WebApplication.CreateBuilder(args);

// adiciona suporte a controllers
builder.Services.AddControllers();

// habilita swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ativa swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// mapeia controllers
app.MapControllers();

app.Run();
