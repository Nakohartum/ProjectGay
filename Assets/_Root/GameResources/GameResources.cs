using ProjectGay.Menu;
using UnityEngine;

namespace ProjectGay.GameResources
{
    [CreateAssetMenu(fileName = nameof(GameResources), menuName = "Game/Resources/"+nameof(GameResources), order = 0)]
    public class GameResources : ScriptableObject
    {
        public MainMenuView MainMenuViewPrefab;
    }
}