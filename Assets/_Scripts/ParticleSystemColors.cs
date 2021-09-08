using UnityEngine;
using ColorSwitch.ObjectColors;

namespace ColorSwitch
{
    [RequireComponent(typeof(ParticleSystem))]
    public class ParticleSystemColors : MonoBehaviour
    {
        [SerializeField] private ColorScriptableObject _colors;

        private ParticleSystem _particleSystem;
        private ParticleSystem.Particle[] _particles = new ParticleSystem.Particle[100];

        private void Awake()
        {
            _particleSystem = GetComponent<ParticleSystem>();
        }

        private void LateUpdate()
        {
            int numOfParticles = _particleSystem.GetParticles(_particles);

            if (_particles != null)
            {
                for (int i = 0; i < numOfParticles; i++)
                {
                    if (_particles[i].startColor == Color.white)
                    {
                        _particles[i].startColor = RandomColor();
                    }
                }
            }

            _particleSystem.SetParticles(_particles, numOfParticles);
        }

        private Color32 RandomColor()
        {
            int random = Random.Range(0, 4) + 1;

            if (random == 1) return _colors.color1;
            else if (random == 2) return _colors.color2;
            else if (random == 3) return _colors.color3;
            return _colors.color4;
        }
    }
}
