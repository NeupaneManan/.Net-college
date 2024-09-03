using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

namespace FirstMvcExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

           //app.MapDefaultControllerRoute();
            app.MapControllerRoute (name = "MyRoute",pattern : "{controller = Home}/{action = NextPage}/{id?}");
            app.Run();
        }
    }
}
