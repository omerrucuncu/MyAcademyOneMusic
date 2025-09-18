using OneMusic.BusinessLayer.Abstract;
using OneMusic.BusinessLayer.Concrete;
using OneMusic.DataAccessLayer.Abstract;
using OneMusic.DataAccessLayer.Concrete;
using OneMusic.DataAccessLayer.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Dependency Injection Configuration for various services and data access layers 
builder.Services.AddScoped<IAboutDal, EFAboutDal>(); // Register EFAboutDal as the implementation for IAboutDal with scoped lifetime 
builder.Services.AddScoped<IAboutService, AboutManager>(); // Register AboutManager as the implementation for IAboutService with scoped lifetime 
// Scoped lifetime means a new instance is created per request 
builder.Services.AddScoped<ISingerDal, EFSingerDal>(); // Register EFSingerDal as the implementation for ISingerDal with scoped lifetime
builder.Services.AddScoped<ISingerService, SingerManager>(); // Register SingerManager as the implementation for ISingerService with scoped lifetime
// This setup allows for easy swapping of implementations and better testability 
builder.Services.AddScoped<ISongDal, EFSongDal>(); // Register EFSongDal as the implementation for ISongDal with scoped lifetime
builder.Services.AddScoped<ISongService, SongManager>(); // Register SongManager as the implementation for ISongService with scoped lifetime

builder.Services.AddScoped<IMessageDal, EFMessageDal>(); // Register EFMessageDal as the implementation for IMessageDal with scoped lifetime
builder.Services.AddScoped<IMessageService, MessageManager>(); // Register MessageManager as the implementation for IMessageService with scoped lifetime

builder.Services.AddScoped<IBannerDal, EFBannerDal>(); // Register EFBannerDal as the implementation for IBannerDal with scoped lifetime
builder.Services.AddScoped<IBannerService, BannerManager>(); // Register BannerManager as the implementation for IBannerService with scoped lifetime

builder.Services.AddScoped<IContactDal, EFContactDal>(); // Register EFContactDal as the implementation for IContactDal with scoped lifetime
builder.Services.AddScoped<IContactService, ContactManager>(); // Register ContactManager as the implementation for IContactService with scoped lifetime

builder.Services.AddScoped<IAlbumDal, EFAlbumDal>(); // Register EFAlbumDal as the implementation for IAlbumDal with scoped lifetime
builder.Services.AddScoped<IAlbumService, AlbumManager>(); // Register AlbumManager as the implementation for IAlbumService with scoped lifetime

builder.Services.AddDbContext<OneMusicContext>(); // Register OneMusicContext for Entity Framework Core with scoped lifetime 
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
