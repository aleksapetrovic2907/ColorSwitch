using UnityEngine;

namespace ColorSwitch.Player
{
    public class CollisionChecker : MonoBehaviour
    {
        [SerializeField] private GameObject _explosionVFX;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if(!other.CompareTag(gameObject.tag))
            {
                Instantiate(_explosionVFX, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
