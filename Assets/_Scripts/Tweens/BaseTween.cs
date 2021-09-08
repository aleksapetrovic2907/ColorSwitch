using UnityEngine;
using DG.Tweening;

namespace ColorSwitch.Tweens
{
    public abstract class BaseTween : MonoBehaviour
    {
        [Header("Base Tween Settings")]
        [SerializeField] protected float _loopDuration;
        [SerializeField] protected int _loopCount;
        [SerializeField] protected LoopType _loopType;
        [SerializeField] protected Ease _ease;
        [SerializeField] protected UpdateType _updateType;

        [SerializeField] protected bool _playOnAwake = true;

        protected Tweener _tweener = null;

        protected virtual void Awake()
        {
            SetTween();

            if (_playOnAwake)
            {
                PlayTween();
            }
        }

        public abstract void SetTween();
        public void PlayTween() => _tweener.Play();
        private void OnDestroy() => _tweener.Kill();
    }
}
