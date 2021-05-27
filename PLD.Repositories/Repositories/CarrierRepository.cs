using PLD.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using PLD.DTO;
using PLD.DataAccess;
using PLD.Repositories.Interface;

namespace PLD.Repositories
{
    public class CarrierRepository: ICarrierRepository<DMTPLDContext,CarrierDTO>
    {
        private readonly DMTPLDContext _context;

        public CarrierRepository(){}
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