using PLD.WebApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PLD.WebApi.DTO;

namespace PLD.WebApi.Repository
{
    public class StatusRepository
    {
        private readonly DMTPLDContext _context;
        public StatusRepository(DMTPLDContext context)
        {    
            _context = context;
        }

        public async Task<List<StatusDTO>> GetRecords()
        {
            var list = await _context.DmtStatCd.Select( o => new StatusDTO
            {
                StatCd = o.StatCd,
                DescTxt = o.DescTxt
            }
            ).ToListAsync();            
            return list;
        }
    }
}