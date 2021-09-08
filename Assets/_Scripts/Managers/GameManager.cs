using UnityEngine;

namespace ColorSwitch
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager current;

        private void Awake()
        {
            if (current != this)
            {
                current = this;
            }

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            EventManager.current.onPointPickedUp += AddPoint;
        }

        #region LOGIC
        public int currentPoints = 0;
        
        private void AddPoint() => currentPoints++;
        #endregion
    }
}
