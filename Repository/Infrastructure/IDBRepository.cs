using Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Infrastructure
{
    public interface IDBRepository
    {
        public IUserRepository UserRepository { get; }
    }
}
