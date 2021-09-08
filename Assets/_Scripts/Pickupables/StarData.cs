using UnityEngine;

namespace ColorSwitch.Pickupables
{
    [CreateAssetMenu(fileName = "StarData", menuName = "ScriptableObjects/StarData")]
    public class StarData : ScriptableObject
    {
        public AudioClip pickupAudio;
        public GameObject pickupParticles;
    }
}
