using Application.Dto.Get;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IScreeningService
    {
        public IEnumerable<ScreeningDetailsDto> GetAllScreenings();
        public ScreeningDetailsDto? GetScreeningDetails(uint id);
    }
}
