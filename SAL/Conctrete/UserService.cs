using AutoMapper;
using DMA;
using Repository.Infrastructure;
using SAL.Abstract;
using Shared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SAL.Conctrete
{
    public class UserService: IUserService
    {
        public IDBRepository _DBRepository;
        public IMapper _mapper;
        public UserService(IDBRepository DBRepository,IMapper mapper)
        {
            _DBRepository = DBRepository;
            _mapper = mapper;
        }

        public async Task<List<UserResponse>> GetUsers()
        {
            List<UserResponse> _userResponses = new List<UserResponse>();
            try { 
            List<User> _userList = await _DBRepository.UserRepository.GetUsers();
            _userList.ForEach(x =>
             {
                 var response = _mapper.Map<UserResponse>(x);
                 _userResponses.Add(response);
             }) ;
            }
            catch(Exception e)
            {
                throw e;
            }
            return _userResponses;
        }
    }
}
