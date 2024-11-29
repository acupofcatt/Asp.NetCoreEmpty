var builder = WebApplication.CreateBuilder(args);

// Uygulamaya mvc desteği ekleniyor
builder.Services.AddControllersWithViews();

var app = builder.Build();

//statik dosyaların kullanılması sağlanıyor
app.UseStaticFiles();

//tarayıcıdan gelen isteklerin yönlendirilmesini sağlıyoruz
app.UseRouting();

//varsayılan routing, home controller içindeki index metoduna gider
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

//controller : model ile view arasında köprü görevi görür, iş mantığını uygular
//action : spesifik olarak bir işlev gerçekleştirir. view veya veri dönen bir metottur
//model : veritabanı tablolarını temsil eder, gerekli veriler modeller içinde tutulur
//view : kullanıcıya gösterilecek ekranlardır (html, css, js)
//razor : mvc için geliştirilmiş html ve c#'ın beraber yazılabilmesini sağlayan şablonlama dilidir
//razorview : razor kullanılarak yazılan viewlerdir
//wwwroot : statik dosyaları barındıran dizindir (css, js, images vb.) 
//builder.Build() : mvc projemizi çalıştırılabilir bir formata getirir
//app.Run() : uygulamayı çalıştırır ve http isteklerini dinlemey başlar