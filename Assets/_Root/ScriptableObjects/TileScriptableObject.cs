using ProjectGay.Tile;
using UnityEngine;

namespace ProjectGay.ScriptableObjectAssets
{
    [CreateAssetMenu(fileName = nameof(TileScriptableObject), menuName = "Game/Tile/"+nameof(TileScriptableObject))]
    public class TileScriptableObject : ScriptableObject
    {
        public InstantiatedTile prefab;
    }
}