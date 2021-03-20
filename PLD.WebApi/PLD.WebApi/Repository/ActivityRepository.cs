using PLD.WebApi.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using PLD.WebApi.DTO;

namespace PLD.WebApi.Repository
{
    public class ActivityRepository
    {  
        private readonly DMTPLDContext _context;
        public ActivityRepository(DMTPLDContext context)
        {
            _context = context;
        }
        public async Task<List<ActivityDTO>> GetRecords()
        {
            var list =  await _context.DmtActCd.Select( o => new ActivityDTO
            {   ActCd = o.ActCd, 
                DescTxt = o.DescTxt
            }   
            ).ToListAsync();
            return list;
        }
    }
}