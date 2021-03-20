using PLD.WebApi.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using PLD.WebApi.DTO;

namespace PLD.WebApi.Repository
{
    public class CarrierRepository
    {
        private readonly DMTPLDContext _context;
        public CarrierRepository(DMTPLDContext context)
        {
            _context = context;
        }
        public async Task<List<CarrierDTO>> GetRecords()
        {
            var list = await _context.DmtCarr.Select( o => new CarrierDTO
            {
               CarrCd = o.CarrCd,
               CarrId = o.CarrId,
               Name = o.Name
            }
            )
            .ToListAsync();            
            return list;
        }

    }
}