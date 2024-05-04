using CinemaSystem.Services.Contracts;

namespace CinemaSystem.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient(typeof(IMoviesService),typeof(MovieService));
            services.AddTransient(typeof(ISeatService),typeof(SeatService));
            return services;
        }
    }
}
