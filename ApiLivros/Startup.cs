using ApiLivros.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using ApiLivros.Data.Repositories;
using ApiLivros.Data.Repositories.Interfaces;
using ApiLivros.Services.Interfaces;
using ApiLivros.Services;

namespace ApiLivros
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDistributedMemoryCache();
            services.AddSession();

            services.AddDbContext<AplicacaoContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:Default"]));

            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddTransient<ILivrosServices, LivrosServices>();
            services.AddTransient<ICadastroRepository, CadastroRepository>();
            services.AddTransient<IItemPedidoRepository, ItemPedidoRepository>();
            //services.AddTransient<IPedidoRepository, PedidoRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
