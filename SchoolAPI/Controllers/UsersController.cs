using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace SchoolAPI.Controllers
{
    [Route("api/v1/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public UsersController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            try
            {
                var users = _repository.User.GetAllUser(trackChanges: false);
                return Ok(users);
                /*var UsersDto = _mapper.Map<IEnumerable<UsersDto>>(users)
                return Ok(UsersDto);*/

            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetUsers)} action {ex}");
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetUsers(Guid id)
        {
            try
            {
                var users = _repository.User.GetUsers(id, trackChanges: false); if (users == null)
                {
                    _logger.LogInfo($"User with id: {id} doesn't exist in the database.");
                    return NotFound();
                }
                else
                {
                    var UsersDto = _mapper.Map<UsersDTO>(users);
                    return Ok(UsersDto);
                }

            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetUsers)} action {ex}");
                return StatusCode(500, "Internal server error");
            }

        }
        
        [HttpPost(Name = "createUser")]
public IActionResult CreateUser([FromBody] UserForCreationDto organization)
{
    if (organization == null)
    {
        _logger.LogError("User ForCreationDto object sent from client is null.");
        return BadRequestResult("User ForCreationDto object is null");
    }
    if (!ModelState.IsValid)
    {
        _logger.LogError("Invalid model state for the OrganizationForCreationDto object");
        return UnprocessableEntity(ModelState);
    }

    var organizationEntity = _mapper.Map<User>(organization);

    _repository.Organization.CreateUser(organizationEntity);
    _repository.Save();

    var organizationToReturn = _mapper.Map<UsersDTO>(organizationEntity);

    return CreatedAtRoute("getUserById", new { id = userToReturn.Id }, userToReturn);
}

        private IActionResult CreatedAtRoute(string v, object p, object userToReturn)
        {
            throw new NotImplementedException();
        }

        IActionResult BadRequestResult(string v)
{
    throw new NotImplementedException();
}

IActionResult BadRequest(string v)
{
    throw new NotImplementedException();
}

        [HttpPut("{id}")]
        public IActionResult UpdateUser(Guid id, [FromBody] UserForUpdateDto user)
        {
            if (user == null)
            {
                _logger.LogError("UserForUpdateDto object sent from client is null.");
                return BadRequest("UserForUpdateDto object is null");
            }
            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the UserForUpdateDto object");
                return UnprocessableEntity(ModelState);
            }
            var organizationEntity = _repository.User.GetUser(id, trackChanges: true);
            if (organizationEntity == null)
            {
                _logger.LogInfo($"User with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _mapper.Map(user, UserEntity);
            _repository.Save();

            return NoContent();
        }

        private void UserEntity(IMappingOperationOptions<object, object>)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(Guid id)
{
    var User = _repository.Organization.GetUser(id, trackChanges: false);
    if (User == null)
    {
        _logger.LogInfo($"User with id: {id} doesn't exist in the database.");
        return NotFound();
    }

    _repository.User.DeleteUser(User);
    _repository.Save();

    return NoContent();
}
    }

    internal interface IMappingOperationOptions<T1, T2, T3>
    {
    }

    internal class userToReturn
    {
        public static object Id { get; internal set; }
    }
}