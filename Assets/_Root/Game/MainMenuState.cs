using ProjectGay.Enums;
using ProjectGay.Menu;
using UnityEngine;

namespace ProjectGay.Game
{
    public class MainMenuState : State
    {
        private MainMenuView _mainMenuViewPrefab;
        private MainMenuView _mainMenuView;
        public MainMenuState(GameController gameController, MainMenuView mainMenuViewPrefab) : base(gameController)
        {
            _mainMenuViewPrefab = mainMenuViewPrefab;
        }
        public override void HandleState()
        {
            _mainMenuView = Object.Instantiate(_mainMenuViewPrefab);
            Debug.Log("MainMenuState");   
        }

        public override void Update(float deltaTime)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                ChangeState(GameState.Pause);
            }
        }
    }
}