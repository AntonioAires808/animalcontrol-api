using System;
using System.Threading.Tasks;
using animalcontrol_webapi.Data;
using animalcontrol_webapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace animalcontrol_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalController : ControllerBase
    {
        private readonly IRepository _repo;

        public AnimalController(IRepository repo)
        {
            _repo = repo;
        }

        // TODO (GET OWNER FIELDS IN OUTPUT)
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAllAnimalsAsync(true);

                return Ok(result);    
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }        
        }

        
        [HttpGet("{AnimalId}")]
        public async Task<IActionResult> GetByAnimalId(int animalId)
        {
            try
            {
                var result = await _repo.GetAnimalAsyncById(animalId, true);

                return Ok(result);    
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }        
        }    

        [HttpGet("ByLearningTopic/{learningTopicId}")]
        public async Task<IActionResult> GetByLearningTopicId(int learningTopicId)
        {
            try
            {
                var result = await _repo.GetAnimalsAsyncByLearningTopicId(learningTopicId, true);

                return Ok(result);    
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }        
        }    

        [HttpPost]
        public async Task<IActionResult> Post(Animal model)
        {
            try
            {
                 _repo.Add(model);
                
                if(await _repo.SaveChangesAsync())
                {
                    return Ok(model);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return BadRequest("");
        }

        [HttpPut("{AnimalId}")]
        public async Task<IActionResult> Put(int animalId, Animal model)
        {
            try
            {
                var animal = await _repo.GetAnimalAsyncById(animalId, false);
                 
                if (animal == null)
                    return NotFound();

                _repo.Update(model);
                
                if(await _repo.SaveChangesAsync())
                {
                    return Ok(model);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return BadRequest("");
        }

        [HttpDelete("{AnimalId}")]
        public async Task<IActionResult> Delete(int animalId)
        {
            try
            {
                var animal = await _repo.GetAnimalAsyncById(animalId, false);
                 
                if (animal == null)
                    return NotFound();

                _repo.Delete(animal);
                
                if(await _repo.SaveChangesAsync())
                {
                    return Ok(animal);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return BadRequest("");
        }
    }
}