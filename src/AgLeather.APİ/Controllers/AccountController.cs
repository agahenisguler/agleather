using AgLeather.Shop.Application.Models.Dtos.Accounts;
using AgLeather.Shop.Application.Models.RequestModels.Accounts;
using AgLeather.Shop.Application.Services.Abstractions;
using AgLeather.Shop.Application.Wrapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgLeather.APİ.Controllers
{
    [ApiController]
    [Route("account")]
    [Authorize]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }


        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<ActionResult<Result<int>>> Register(RegisterVM createUserVM)
        {
            var result = await _accountService.Register(createUserVM);
            return Ok(result);
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<Result<TokenDto>>> Login(LoginVM loginVM)
        {
            var result = await _accountService.Login(loginVM);
            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<ActionResult<Result<int>>> UpdateUser(int? id, UpdateUserVM updateUserVM)
        {
            if (id != updateUserVM.Id)
            {
                return BadRequest();
            }
            var result = await _accountService.UpdateUser(updateUserVM);
            return Ok(result);
        }
    }
}
