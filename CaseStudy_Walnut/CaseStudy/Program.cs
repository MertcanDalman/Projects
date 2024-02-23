using DevExpress.Xpo.DB;
using DevExpress.Xpo;

var builder = WebApplication.CreateBuilder(args);

//string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=YourDatabaseName;Integrated Security=True";
//IDataLayer dataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.DatabaseAndSchema);
//Session session = new Session(dataLayer);

builder.Services.AddControllersWithViews();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

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
