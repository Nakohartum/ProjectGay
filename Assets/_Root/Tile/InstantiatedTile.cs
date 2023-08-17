using UnityEngine;

namespace ProjectGay.Tile
{
    public class InstantiatedTile : MonoBehaviour
    {
        [field: SerializeField] public Transform PlayerSpawnPlace { get; private set; }
        public InstantiatedTile NextTile { get; private set; }
        
        
        public void Initialize(InstantiatedTile nextTile)
        {
            NextTile = nextTile;
        }
    }
}