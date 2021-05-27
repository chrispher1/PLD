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
    public class ActivityRepository: IActivityRepository<DMTPLDContext,ActivityDTO>
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