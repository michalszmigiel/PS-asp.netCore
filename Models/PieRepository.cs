using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly PSDbContext _psDbContext;

        public PieRepository(PSDbContext psDbContext)
        {
            _psDbContext = psDbContext;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _psDbContext.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _psDbContext.Pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
