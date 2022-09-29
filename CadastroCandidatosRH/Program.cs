using CadastroCandidatosRH.Data;
using CadastroCandidatosRH.Repository;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//string mySqlConnection =
//       builder.Configuration.GetConnectionString("DefaultConnection");

//builder.Services.AddDbContextPool<CadastroContext>(options =>
//          options.UseMySql(mySqlConnection,
//            ServerVersion.AutoDetect(mySqlConnection)));

string sqlConnection =
    builder.Configuration.GetConnectionString("CadastroConnection");
    builder.Services.AddDbContextPool<CadastroContext>(options =>
          options.UseSqlServer(sqlConnection));
builder.Services.AddScoped<ICadastroRepositorio, CadastroRepositorio>();


builder.Services.AddControllersWithViews();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
