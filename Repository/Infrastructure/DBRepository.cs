using DMA;
using Repository.Abstract;
using Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Infrastructure
{
    public class DBRepository : IDBRepository
    {
        public readonly AppDbContext _context;
        public DBRepository()
        {
            _context = new AppDbContext();
        }
        public IUserRepository _UserRepository;
        public IUserRepository UserRepository
        {
            get
            {
                if (_UserRepository == null)
                {
                    _UserRepository = new UserRepository(_context);
                }
                return _UserRepository;
            }
        }
    }
}
