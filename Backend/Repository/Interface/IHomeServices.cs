using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Backend.Data
{
    public interface IHomeServices
    {
        Task<List<MyXp>> ListXp();
    }
}