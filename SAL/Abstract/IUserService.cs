using Shared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SAL.Abstract
{
    public interface IUserService
    {
        Task<List<UserResponse>> GetUsers();
    }
}
