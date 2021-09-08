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

        private Rigidbody2D _rigidbody2D;

        protected override void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            base.Awake();
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
