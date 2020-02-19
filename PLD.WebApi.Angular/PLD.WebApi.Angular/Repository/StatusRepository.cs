using PLD.WebApi.Angular.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PLD.WebApi.Angular.Repository
{
    public class StatusRepository
    {
        private readonly DMTPLDContext _context;
        public StatusRepository(DMTPLDContext context)
        {    
            _context = context;
        }

        public async Task<List<DmtStatCd>> GetRecords()
        {
            var list = await _context.DmtStatCd.ToListAsync();            
            return list;
        }
    }
}