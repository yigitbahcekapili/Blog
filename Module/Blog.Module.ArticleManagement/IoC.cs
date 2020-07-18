using Blog.Module.ArticleManagement.Contract;
using Blog.Module.ArticleManagement.Workflow;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Module.ArticleManagement
{
    public static class IoC
    {
        public static void InstallArticleManagementIoC(this IServiceCollection services)
        {
            services.AddScoped<IArticleContract, ArticleWorkflow>();
        }
    }
}
