using System.Collections.Generic;
using _Root.ScriptableObjects;
using ProjectGay.ScriptableObjectAssets;
using ProjectGay.ScriptableObjects;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

namespace ProjectGay.Tile
{
    public class LevelGenerator
    {
        private GameResources _gameResources;
        private LevelScriptableObject _levelScriptableObject;
        private TileScriptableObject[] _tileScriptableObjects;
        private InstantiatedTile[] _spawnedTiles;

        public LevelGenerator(GameResources gameResources)
        {
            _gameResources = gameResources;
            _levelScriptableObject = _gameResources.LevelScriptableObject;
            _tileScriptableObjects = new TileScriptableObject[_levelScriptableObject.LevelSizeInTiles];
            _spawnedTiles = new InstantiatedTile[_levelScriptableObject.LevelSizeInTiles];
        }

        public void GenerateLevel()
        {
            ClearLevel();
            ChooseRandomTilesToSpawn();
            SpawnTiles();
            SpawnPlayer(_spawnedTiles[0]);
        }

        private void ClearLevel()
        {
            if (_spawnedTiles[0] == null)
            {
                return;
            }
            for (int i = 0; i < _spawnedTiles.Length; i++)
            {
                Object.Destroy(_spawnedTiles[i].gameObject);
                _spawnedTiles[i] = null;
            }
        }

        private void ChooseRandomTilesToSpawn()
        {
            for (int i = 0; i < _tileScriptableObjects.Length; i++)
            {
                _tileScriptableObjects[i] = _levelScriptableObject.TileScriptableObjects[Random.Range(0, _levelScriptableObject.TileScriptableObjects.Length)];
            }
        }

        private void SpawnTiles()
        {
            for (int i = 0; i < _spawnedTiles.Length; i++)
            {
                _spawnedTiles[i] = Object.Instantiate(_tileScriptableObjects[i].prefab, 
                    new Vector3(i * Settings.Settings.TileWidth, 0, 0), Quaternion.identity);
                SpawnTraps(_spawnedTiles[i]);
            }

            InitializeTiles();
        }

        private void InitializeTiles()
        {
            for (int i = 0; i < _spawnedTiles.Length; i++)
            {
                if (i < _spawnedTiles.Length - 1)
                {
                    _spawnedTiles[i].Initialize(_spawnedTiles[i + 1]);
                }
            }
            _spawnedTiles[^1].Initialize(null);
        }

        private void SpawnTraps(InstantiatedTile tile)
        {
            
        }
        
        private void SpawnPlayer(InstantiatedTile spawnedTile)
        {
            Object.Instantiate(_gameResources.PlayerPrefab, spawnedTile.PlayerSpawnPlace.position, quaternion.identity);
        }
    }
}