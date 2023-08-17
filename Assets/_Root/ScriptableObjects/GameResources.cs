using _Root.ScriptableObjects;
using ProjectGay.Menu;
using UnityEngine;

namespace ProjectGay.ScriptableObjects
{
    [CreateAssetMenu(fileName = nameof(GameResources), menuName = "Game/Resources/"+nameof(GameResources), order = 0)]
    public class GameResources : ScriptableObject
    {
        public MainMenuView MainMenuViewPrefab;
        public LevelScriptableObject LevelScriptableObject;
        public GameObject PlayerPrefab;
    }
}