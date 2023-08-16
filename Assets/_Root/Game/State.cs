using ProjectGay.Enums;

namespace ProjectGay.Game
{
    public abstract class State : IUpdatable
    {
        private GameController _gameController;

        protected State(GameController gameController)
        {
            _gameController = gameController;
        }

        protected void ChangeState(GameState state)
        {
            _gameController.ChangeState(state);
        }
        
        public abstract void HandleState();
        public abstract void Update(float deltaTime);
    }
}