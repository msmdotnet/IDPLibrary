using IDPLibrary.Entities.Options;
using IDPLibrary.Entities.ValueObjects;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/*** IDP Library Services ***/
//var Keys = builder.Configuration.GetSection(JwksOptions.SectionKey).Get<Jwk[]>();

builder.Services.AddIDPLibraryServices(
    jwksOptions => jwksOptions.Keys = builder.Configuration.GetSection(JwksOptions.SectionKey).Get<Jwk[]>());
/*** IDP Library Services ***/


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

/*** IDP Library Endpoints ***/
app.UseIDPLibraryEndpoints();
/*** IDP Library Endpoints ***/



app.Run();
