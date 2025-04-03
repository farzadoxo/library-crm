using Application.Interfaces.Repository;
using Infrastructure.Data.Contexts;
using Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDbContext<LibraryContext>();
builder.Services.AddScoped<IBookRepository,BookRepository>();
builder.Services.AddScoped<IMemberRepository,MemberRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapControllers();
}

app.Run();