using UnityEngine;

namespace ColorSwitch.Player
{
    public class Input : MonoBehaviour
    {
        public bool jumpInput { get; private set; }

        private void Update()
        {
            jumpInput = UnityEngine.Input.GetKeyDown(KeyCode.Space);
        }
    }
}
