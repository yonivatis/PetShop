using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using PetShopProject.BusinessServices;
using PetShopProject.Data;
using PetShopProject.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IRepository, MyRepository>();
builder.Services.AddTransient<IHomeService, HomeService>();
builder.Services.AddTransient<ICatalogService, CatalogService>();
builder.Services.AddTransient<IPetService, PetService>();
builder.Services.AddTransient<IAdminService, AdminService>();
string connectionString = builder.Configuration["ConnectionStrings:DefaultConnection"];
builder.Services.AddDbContext<PetShopContext>(options => {
    options.UseLazyLoadingProxies().UseSqlite(connectionString);
});
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
}).AddEntityFrameworkStores<PetShopContext>();
builder.Services.AddControllersWithViews(option =>
{
    var policy = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();
    option.Filters.Add(new AuthorizeFilter(policy));
});
var app = builder.Build();


app.UseStaticFiles();
app.UseRouting(); 
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});

app.Run();
