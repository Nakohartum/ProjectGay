using ProjectGay.ScriptableObjectAssets;
using UnityEngine;

namespace _Root.ScriptableObjects
{
    [CreateAssetMenu(fileName = nameof(LevelScriptableObject), menuName = "Game/Level/"+nameof(LevelScriptableObject), order = 0)]
    public class LevelScriptableObject : ScriptableObject
    {
        public TileScriptableObject[] TileScriptableObjects;
        public int LevelSizeInTiles;
    }
}