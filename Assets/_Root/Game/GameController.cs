using System;
using ProjectGay.Enums;
using ProjectGay.ScriptableObjects;
using ProjectGay.Tile;
using UnityEngine;

namespace ProjectGay.Game
{
    public class GameController : IUpdatable
    {
        private GameResources _gameResources;
        public State State { private set; get; }
        public LevelGenerator LevelGenerator { get; }

        public GameController(GameState currentGameState, GameResources gameResources)
        {
            _gameResources = gameResources;
            LevelGenerator = new LevelGenerator(gameResources);
            ChooseState(currentGameState);
            State.HandleState();
        }

        public void ChangeState(GameState state)
        {
            ChooseState(state);
            State.HandleState();
        }

        private void ChooseState(GameState state)
        {
            switch (state)
            {
                case GameState.MainMenu:
                    State = new MainMenuState(this, _gameResources.MainMenuViewPrefab);
                    break;
                case GameState.LevelChoosing:
                    break;
                case GameState.PlayingLevel:
                    break;
                case GameState.Pause:
                    State = new PauseState(this);
                    break;
                case GameState.Lobby:
                    break;
                default:
                    State = new StubState(this);
                    break;
            }
        }

        public void Update(float deltaTime)
        {
            State.Update(deltaTime);
        }
    }
}