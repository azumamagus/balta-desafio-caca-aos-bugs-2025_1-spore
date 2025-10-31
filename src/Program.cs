using BugStore.Data;

var builder = WebApplication.CreateBuilder(args);

var cnnString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlite(cnnString));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
