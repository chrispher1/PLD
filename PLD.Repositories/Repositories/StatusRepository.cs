using PLD.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PLD.DTO;
using PLD.DataAccess;
using PLD.Repositories.Interface;

namespace PLD.Repositories
{
    public class StatusRepository: IStatusRepository<DMTPLDContext,StatusDTO>
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
        public async Task<List<StatusDTO>> GetRecords(string filter)
        {
            var list = await _context.DmtStatCd.Where( e => e.StatCd != filter).Select( o => new StatusDTO
            {
                StatCd = o.StatCd,
                DescTxt = o.DescTxt
            }
            ).ToListAsync();            
            return list;
        }
    }
}