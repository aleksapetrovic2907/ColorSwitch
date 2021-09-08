using UnityEngine;
using ColorSwitch.ObjectColors;

namespace ColorSwitch.Player
{
    [RequireComponent(typeof(ColorController))]
    public class CollisionChecker : MonoBehaviour
    {
        [SerializeField] private GameObject _explosionVFX;
        private ColorController _colorController;

        private void Awake()
        {
            _colorController = GetComponent<ColorController>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.CompareTag(gameObject.tag) && other.gameObject.layer == 3)
            {
                Instantiate(_explosionVFX, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            else if (other.CompareTag("ColorChanger"))
            {
                ChangeColor();
                Destroy(other.gameObject);
            }
            else if (other.CompareTag("Star"))
            {
                PickupStar();
                Destroy(other.gameObject);
            }
        }

        private void ChangeColor() => _colorController.SetRandomColor();
        private void PickupStar() => EventManager.current.PointPickedUp();
    }
}
