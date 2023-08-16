using UnityEngine;

namespace ProjectGay.Game
{
    public class PauseState : State
    {
        public PauseState(GameController gameController) : base(gameController)
        {
        }

        public override void HandleState()
        {
            Debug.Log("PauseState");
        }

        public override void Update(float deltaTime)
        {
            
        }

    }
}