using System;
using System.Collections;
using System.Collections.Generic;
using ProjectGay.Enums;
using ProjectGay.Game;
using UnityEngine;

namespace ProjectGay
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private GameState _initialGameState;
        [SerializeField] private GameResources.GameResources _gameResources;
        private GameController _gameController;

        private void Awake()
        {
            _gameController = new GameController(_initialGameState, _gameResources);
        }

        private void Update()
        {
            _gameController.Update(Time.deltaTime);
        }
    }
}
