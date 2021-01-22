using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class HomeServices : IHomeServices
    {
        private readonly Context _db;
        public HomeServices(Context db)
        {
            this._db = db;
        }
        public async Task<List<MyXp>> ListXp()
        {
            return await _db.MyXp.ToListAsync();
        }
    }
}