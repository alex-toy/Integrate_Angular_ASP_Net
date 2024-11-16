namespace HelloWorldApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", builder =>
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader());
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseCors("AllowAll");

            app.UseStaticFiles();

            //app.MapFallbackToFile("/app/{**catchall}", "/index.html");
            app.MapFallbackToFile("index.html");

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllers();

            Console.WriteLine("Current Working Directory: " + Directory.GetCurrentDirectory());

            app.Run();
        }
    }
}