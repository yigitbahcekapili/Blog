using Blog.Infrastructure.Data.Contract;
using Blog.Infrastructure.Data.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Infrastructure.Data
{
    public static class IoC
    {
        //test
        public static void InstallDataIoC(this IServiceCollection services)
        {
            services.AddTransient<IArticleRepository, ArticleRepository>();
        }
    }
}
