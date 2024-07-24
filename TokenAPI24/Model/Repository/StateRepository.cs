using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using TokenAPI24.Model.Interface;
using TokenAPI24.Model.Request;

namespace TokenAPI24.Model.Repository
{
    public class StateRepository : IState
    {
        private readonly ApplicationDbContext _context;
        public StateRepository(ApplicationDbContext context)
        {
            _context = context;
        }

            public bool AddState(StateRequest stateRequest)
        {
            try
            {
                State state = new State();
                state.Name = stateRequest.Name;
                state.CountryId = stateRequest.CountryId;
                _context.states.Add(state);
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                State state = _context.states.Find(id);
                _context.states.Remove(state);  
                _context.SaveChanges(true);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(StateRequest stateRequest)
        {
            try
            {
                State state = new State();
                state.Id = stateRequest.Id;
                state.Name = stateRequest.Name;
                state.CountryId = stateRequest.CountryId;
                _context.states.Update(state);
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return true;
            }
        }

        public List<StateRequest> GetAllState()
        {
         var data = _context.states.ToList();
            List<StateRequest> list = new List<StateRequest>();
            foreach (var state in data)
            {
                StateRequest stateRequest = new StateRequest();
                stateRequest.Id = state.Id;
                stateRequest.Name = state.Name;
                stateRequest.CountryId = state.CountryId;
                list.Add(stateRequest);

            }
            return list;
        }

        public StateRequest GetStateById(int id)
        {
            var data = _context.states.Find(id);
            StateRequest stateRequest = new StateRequest();
            stateRequest.Id = data.Id;
            stateRequest.Name = data.Name;
            stateRequest.CountryId= data.CountryId; 
            return stateRequest;
        }

       
    }
}
