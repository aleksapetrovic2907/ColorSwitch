using UnityEngine;

namespace ColorSwitch.Player
{
    public class CollisionChecker : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if(!other.CompareTag(gameObject.tag))
            {
                Destroy(gameObject);
            }
        }
    }
}
