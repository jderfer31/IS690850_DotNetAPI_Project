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

        [HttpGet(Name = "getAllUsers")]
        public IActionResult GetUsers()
        {
            var user = _repository.User.GetAllUser(trackChanges: false);

            var UsersDTO = _mapper.Map<IEnumerable<UsersDTO>>(user);
            //uncomment the code below to test the global exception handling
            //throw new Exception("Exception");
            return Ok(UsersDTO);
        }

        [HttpGet("{id}", Name = "getUsersById")]
        public IActionResult GetUsers(Guid id)
        {
            var user = _repository.User.GetUser(id, trackChanges: false); if (user == null)
            {
                _logger.LogInfo($"Users with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                var UsersDTO = _mapper.Map<UsersDTO>(user);
                return Ok(UsersDTO);
            }
        }

        [HttpPost(Name = "createUsers")]
        public IActionResult CreateUsers([FromBody] UserForCreationDTO users)
        {
            if (users == null)
            {
                _logger.LogError("Users ForCreationDTO object sent from client is null.");
                return BadRequest("Users ForCreationDTO object is null");
            }
            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the UsersForCreationDTO object");
                return UnprocessableEntity(ModelState);
            }

            var userEntity = _mapper.Map<User>(User);

            _repository.User.CreateUser(userEntity);
            _repository.Save();

            var userToReturn = _mapper.Map<UsersDTO>(userEntity);

            return CreatedAtRoute("getUserById", new { id = userToReturn.Id }, userToReturn);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(Guid id, [FromBody] UserForUpdateDTO users)
        {
            if (User == null)
            {
                _logger.LogError("UserForUpdateDTO object sent from client is null.");
                return BadRequest("UserForUpdateDTO object is null");
            }
            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the UserForUpdateDTO object");
                return UnprocessableEntity(ModelState);
            }
            var userEntity = _repository.User.GetUser(id, trackChanges: true);
            if (userEntity == null)
            {
                _logger.LogInfo($"Users with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _mapper.Map(User, userEntity);
            _repository.Save();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(Guid id)
        {
            var user = _repository.User.GetUser(id, trackChanges: false);
            if (user == null)
            {
                _logger.LogInfo($"User with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _repository.User.DeleteUser(user);
            _repository.Save();

            return NoContent();
        }
    }
}