using System.Reflection;
using MediatR.Infrastrucutre;
using NetCore.AutoRegisterDi;
using Microsoft.EntityFrameworkCore;
using MediatR.Api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Db set up
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<MediatRDbContext>(options => options.UseSqlServer(connectionString));

ConfigureAutoMapper(builder);

// Dependency Injection
builder.Services.RegisterRequestHandlers();
InjectPatternFromAssemblies(builder, "Service");
InjectPatternFromAssemblies(builder, "Repository");
InjectPatternFromAssemblies(builder, "Request");
InjectPatternFromAssemblies(builder, "Handler");

var app = builder.Build();

await EnsureDbIsMigrated(app.Services);

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

void ConfigureAutoMapper(WebApplicationBuilder builder)
{
    builder.Services.AddAutoMapper(GetAssemblies());
}

async Task EnsureDbIsMigrated(IServiceProvider services)
{
    using var scope = services.CreateScope();
    using var ctx = scope.ServiceProvider.GetService<MediatRDbContext>();
    if (ctx != null)
    {
        await ctx.Database.MigrateAsync();
    }
}

void InjectPatternFromAssemblies(WebApplicationBuilder builder, string pattern, params Assembly[] assembly)
{
    builder.Services.RegisterAssemblyPublicNonGenericClasses(GetAssemblies())
            .Where(c => c.Name.EndsWith(pattern, StringComparison.CurrentCultureIgnoreCase))
            .AsPublicImplementedInterfaces();
}

static Assembly[] GetAssemblies()
{
    var MediatR = AppDomain.CurrentDomain.GetAssemblies().Where(x => x.FullName!.Contains("MediatR")).ToList();

    MediatR.Add(Assembly.Load("MediatR.Infrastrucutre"));
    MediatR.Add(Assembly.Load("MediatR.Service"));
    MediatR.Add(Assembly.Load("MediatR.Domain"));
    MediatR.Add(Assembly.Load("MediatR.Requests"));
    MediatR.Add(Assembly.Load("MediatR.Handlers"));

    return MediatR.ToArray();
}
