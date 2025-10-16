using GB.Gamemodes;
using UnityEngine;

namespace GBMDK
{
    [CreateAssetMenu(fileName = "NewMap-Info", menuName = "GBMDK/Custom Map Info")]
    public class CustomMapInfo : ScriptableObject
    {
        public GameModeEnum allowedGamemodes;
    }
}