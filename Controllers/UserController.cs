using FirstApi.Comunication.Requests;
using FirstApi.Comunication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers;

[Route("api/[controller]")]
[ApiController]

public class UserController : ControllerBase
{
    [HttpGet]
    [Route("{id}")] // --> Altera a URL para api/user/{id}, aceita mais parâmetros
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)] // -> e passado a classe que contem o retorno 
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult GetById()
    {
        var response = new User
        {
            Id = 1,
            Name = "Kayo Rafael",
            Age = 21
        };
        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
    public IActionResult CreateUser([FromBody] RequestRegisterUserJson request)
    {
        var response = new ResponseRegisteredUserJson
        {
            id = 1,
            name = request.Name,
            email = request.Email
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult UpdateUser([FromBody] RequestUpdateProfileUserJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult DeleteUser()
    {
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
    public IActionResult getAllUsers()
    {
        var response = new List<User>
        {
            new User
            {
                Id = 1,
                Name = "Kayo Rafael",
                Age = 21
            },
            new User
            {
                Id = 2,
                Name = "Lucas",
                Age = 22
            }
        };
        return Ok(response);
    }


    [HttpPut]
    [Route("change-password")] // --> Altera a URL para api/user/change-password, para evitar conflitos com o outro metodo put
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult changePassword([FromBody] RequestChangePasswordJson request )
    {
        return NoContent();
    }
}
