using Terap.Application.Contracts.Persistence;
using Terap.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Terap.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("ApplicationConnectionString")));
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ITherepistBankDetailsRepository, TherepistBankDetailsRepository>();
            services.AddScoped<IBankRepository, BankRepository>();
            services.AddScoped<ITherapistChargesRepository, TherapistChargesRepository>();
            services.AddScoped<ITherapistRepository, TherapistRepository>();
            services.AddScoped<IDocumentRepository, DocumentRepository>();
            services.AddScoped<IVideoRepository, VideoRepository>();
            services.AddScoped<IImageRepository, ImageRepository>();

            return services;
        }
    }
}
