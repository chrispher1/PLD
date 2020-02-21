using PLD.WebApi.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PLD.WebApi.Repository
{
    public class ActivityRepository
    {
        
        private readonly DMTPLDContext _context;
        public ActivityRepository(DMTPLDContext context)
        {
            _context = context;
        }
        public async Task<List<DmtActCd>> GetRecords()
        {
            var list = await _context.DmtActCd.ToListAsync();
            return list;
        }
    }
}