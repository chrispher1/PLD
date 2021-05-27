using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PLD.DTO;

namespace PLD.Repositories.Interface
{
    public interface ICarrierRepository<Context, DTO> where Context:DbContext where DTO:class 
    {
        Task<List<DTO>> GetRecords();
    }
}