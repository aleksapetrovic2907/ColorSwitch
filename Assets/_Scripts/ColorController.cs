using UnityEngine;

namespace ColorSwitch
{
    public enum PossibleColor
    {
        Yellow,
        Purple,
        Cyan,
        Pink
    }

    [RequireComponent(typeof(SpriteRenderer))]
    public class ColorController : MonoBehaviour
    {
        [SerializeField] private bool _setRandomColorOnAwake = true;

        public PossibleColor currentColor;

        private SpriteRenderer _spriteRenderer;

        private void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();

            if (_setRandomColorOnAwake)
            {
                SetRandomColor();
            }
        }

        private void SetRandomColor()
        {
            SetColor((PossibleColor)Random.Range(0, 4));
        }

        public void SetColor(PossibleColor color)
        {
            currentColor = color;

            switch (currentColor)
            {
                case PossibleColor.Yellow:
                    gameObject.tag = "Yellow";
                    _spriteRenderer.color = new Color32(246, 223, 14, 255);
                    break;
                case PossibleColor.Purple:
                    gameObject.tag = "Purple";
                    _spriteRenderer.color = new Color32(140, 19, 251, 255);
                    break;
                case PossibleColor.Cyan:
                    gameObject.tag = "Cyan";
                    _spriteRenderer.color = new Color32(53, 226, 242, 255);
                    break;
                case PossibleColor.Pink:
                    gameObject.tag = "Pink";
                    _spriteRenderer.color = new Color32(255, 0, 128, 255);
                    break;
            }
        }
    }
}
