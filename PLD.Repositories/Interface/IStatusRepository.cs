using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PLD.Repositories.Interface
{
    public interface IStatusRepository<Context, DTO> where Context:DbContext where DTO:class 
    {
         Task<List<DTO>> GetRecords();
         Task<List<DTO>> GetRecords(string filter);

    }
}