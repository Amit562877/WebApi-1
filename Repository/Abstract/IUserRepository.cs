using DMA;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstract
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsers();
    }
}
