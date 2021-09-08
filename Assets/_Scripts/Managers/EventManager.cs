using System;
using UnityEngine;

namespace ColorSwitch
{
    public class EventManager : MonoBehaviour
    {
        public static EventManager current;

        private void Awake()
        {
            if(current != this)
            {
                current = this;
            }
        }

        public event Action onPointPickedUp;

        public void PointPickedUp()
        {
            if(onPointPickedUp != null) onPointPickedUp();
        }
    }
}
