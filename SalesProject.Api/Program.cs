using Microsoft.EntityFrameworkCore;
using SalesProject.Domain.Handlers;
using SalesProject.Domain.Infra.Data;
using SalesProject.Domain.Infra.Repositories;
using SalesProject.Domain.Repositories;

var builder = WebApplication.CreateBuilder(args);
{

    builder.Services.AddControllers();

    var connection = builder.Configuration.GetConnectionString("DefaultConnection");
    builder.Services.AddDbContext<SalesProjectDbContext>(options => options.UseSqlServer(connection));

    builder.Services.AddTransient<IUserRepository, UserRepository>();
    builder.Services.AddTransient<IRoleRepository, RoleRepository>();
    builder.Services.AddTransient<IProductRepository, ProductRepository>();
    builder.Services.AddTransient<IOrderRepository, OrderRepository>();

    builder.Services.AddTransient<UserHandler, UserHandler>();
    builder.Services.AddTransient<RoleHandler, RoleHandler>();
    builder.Services.AddTransient<ProductHandler, ProductHandler>();
    builder.Services.AddTransient<OrderHandler, OrderHandler>();

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}
var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();

    app.Run();
}