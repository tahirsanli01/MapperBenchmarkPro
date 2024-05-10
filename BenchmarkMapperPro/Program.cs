using BenchmarkMapperPro.CrossCutting;
using BenchmarkMapperPro.CrossCutting.Core;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDependencyResolvers
    (
        [ 
            new MapsterCoreModule(), 
            new AutoMapperCoreModule(),
            new MapperlyCoreModule(),
            new TinyMapCoreModule()
        ]
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
