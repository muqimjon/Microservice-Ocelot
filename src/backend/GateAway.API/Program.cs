using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);


// 1 ---------------------- Add file configurations --------------------------------------------/
// ---------------------------------------------------------------------------  For Gate Away  /
builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)////////----------------/
    .AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);//////----------------/
//------------------------------------------------------------------------------------------/


// Add services to the container.
builder.Services.AddControllers();


// 2 --------------- Add ----------------------------/
// --------------------------------  For Gate Away  /
builder.Services.AddOcelot();//////----------------/
//------------------------------------------------/


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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


// 3 -- Integration with web app --------------/
// --------------------------  For Gate Away  /
app.UseOcelot().Wait();//////----------------/
//------------------------------------------/


app.Run();
