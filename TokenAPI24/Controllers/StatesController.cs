using Microsoft.AspNetCore.Mvc;
using TokenAPI24.Model;
using TokenAPI24.Model.Interface;
using TokenAPI24.Model.Request;


namespace TokenAPI24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : ControllerBase
    {
       private readonly IState _state;
        public StatesController(IState state)
        {
            _state = state;


        }


        [Route("GetAllState")]
        [HttpGet]
        public IActionResult GetAllState()
        {
            return Ok(_state.GetAllState());
        }

        [Route("GetStateByIdGet")]
        [HttpGet]
        public IActionResult GetStateByIdGet(int id)
        {
            return Ok(_state.GetStateById(id));
        }

        [Route("AddState")]
        [HttpPost]
        public IActionResult AddState(StateRequest stateRequest)
        {
            return Ok(_state.AddState(stateRequest));
        }

        [Route("Update")]
        [HttpPut]
        public IActionResult Update(StateRequest stateRequest)
        {
            return Ok(_state.Update(stateRequest));
        }

        [Route("Delete")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_state.Delete(id));
        }
    }
}
