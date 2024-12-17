using Application.Interfaces;
using Application.Services;
using Domain.Interfaces;
using Infrastructure.Repositories;

namespace WebAPI.Installers
{
    public class ApplicationBuilder : IBuilder
    {
        public void Build(IServiceCollection services)
        {
            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<IScreeningService, ScreeningService>();
            services.AddScoped<ITicketTypeService, TicketTypeService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<IReservationHistoryService, ReservationHistoryService>();
        }
    }
}
