using Microsoft.AspNetCore.Mvc;
using SAL.Abstract;
using Shared.BaseResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_1.Controllers
{
    [Route("api/[controller]/[action]")]
    public class UserController : Controller
    {
        IUserService _UserService;
        public UserController(IUserService UserService)
        {
            _UserService = UserService;
        }
        [HttpGet]
        public async Task<ResponseModel> getAllUsers()
        {
            ResponseModel responseModel = new ResponseModel();
            try { 
            responseModel.data=await _UserService.GetUsers();
            responseModel.code = 1;
            }catch(Exception e)
            {
                responseModel.code = 0;
                responseModel.message = e.Message.ToString();
            }
            return responseModel;
        }
    }
}
