using UnityEngine;

namespace ColorSwitch.Pickupables
{
    public class Star : MonoBehaviour
    {
        [SerializeField] private StarData _starData;
        [SerializeField] private AudioSource _audioSource;

        private void OnDestroy()
        {
            // Play Audio()
            Instantiate(_starData.pickupParticles, transform.position, Quaternion.identity);
        }
    }
}
