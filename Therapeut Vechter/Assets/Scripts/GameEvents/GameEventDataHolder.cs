using UnityEngine;

namespace GameEvents
{
    [CreateAssetMenu(menuName = "Game Events/Game Event Data Holder",order = 1)]
    public class GameEventDataHolder : ScriptableObject
    {
        public Sprite startingBackground;
        
        public BaseGameEvent[] gameEvents;
    }
}