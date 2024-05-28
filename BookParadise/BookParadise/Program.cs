using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

using BookParadise.Persistence.DBContextFolder;
using BookParadise.Persistence.Repository.ConcreteClass;
using BookParadise.Persistence.Repository.Interface;
using BookParadise.Domain.Models;
using BookParadise.Application.Service.Interface;
using BookParadise.Application.Service.ConcreteClass;
using BookParadise.Persistence.SeederFolder;

var builder = WebApplication.CreateBuilder(args);

// Configuration
builder.Services.AddDbContext<BookParadiseDb>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddIdentity<User, IdentityRole>(options => ConfigureIdentityOptions(options))
    .AddEntityFrameworkStores<BookParadiseDb>()
    .AddDefaultTokenProviders();
builder.Services.AddTransient<SeedRole>();
// Dependency Injection
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();  
builder.Services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IRabbitMQService, RabbitMQService>();
//builder.Services.AddScoped<InventoryManagementService>();

// API features
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Swagger documentation (optional)
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "BookParadise API", Version = "v1" });
    });
}

// Build and run the application
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    await SeedRole.SeedRoles(serviceProvider);
}
app.UseHttpsRedirection();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

// Identity configuration helper function (optional)
static void ConfigureIdentityOptions(IdentityOptions options)
{
    options.SignIn.RequireConfirmedPhoneNumber = false;
    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedAccount = false;
    options.User.RequireUniqueEmail = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = true;
}
