using TokenAPI24.Model.Request;

namespace TokenAPI24.Model.Interface
{
    public interface IState
    {

        bool AddState(StateRequest stateRequest);
        bool Update(StateRequest stateRequest);
        bool Delete(int id);

        List<StateRequest> GetAllState();
        StateRequest GetStateById(int id);

    }
}
