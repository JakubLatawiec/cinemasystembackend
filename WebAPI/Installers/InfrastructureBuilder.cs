using Domain.Interfaces;
using Domain.Repositories;
using Infrastructure.Repositories;

namespace WebAPI.Installers
{
    public class InfrastructureBuilder : IBuilder
    {
        public void Build(IServiceCollection services)
        {
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IScreeningRepository, ScreeningRepository>();
            services.AddScoped<ITicketTypeRepository, TicketTypeRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IReservationRepository, ReservationRepository>();
            services.AddScoped<IReservationHistoryRepository, ReservationHistoryRepository>();
        }
    }
}
