using UnityEngine;
using DG.Tweening;

namespace ColorSwitch.Tweens
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Rotate : BaseTween
    {
        [Header("Rotation Settings")]
        [SerializeField] private float _rotationStart;
        [SerializeField] private float _rotationEnd;
        [SerializeField] private bool _randomizeDirection = false;

        private Rigidbody2D _rigidbody2D;

        protected override void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            RandomizeDirection();
            base.Awake();
        }

        private void RandomizeDirection()
        {
            if (_randomizeDirection)
            {
                var range = new System.Random();
                _rotationEnd *= range.Next(0, 2) > 0 ? 1 : -1;
            }
        }

        public override void SetTween()
        {
            _tweener = _rigidbody2D
                .DORotate(_rotationEnd, _loopDuration)
                .From(_rotationStart)
                .SetEase(_ease)
                .SetLoops(_loopCount, _loopType)
                .SetUpdate(_updateType).Play();
        }
    }
}
