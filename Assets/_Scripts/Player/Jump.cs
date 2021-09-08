using UnityEngine;

namespace ColorSwitch.Player
{
    [RequireComponent(typeof(Input))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class Jump : MonoBehaviour
    {
        [SerializeField] private float _yVelocity;

        private Input _input;
        private Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _input = GetComponent<Input>();
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (_input.jumpInput)
            {
                _rigidbody2D.simulated = true;
                _rigidbody2D.velocity = Vector2.up * _yVelocity;
            }
        }
    }
}
