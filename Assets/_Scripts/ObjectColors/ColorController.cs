using UnityEngine;

namespace ColorSwitch.ObjectColors
{
    public enum ObjectColor
    {
        Color1,
        Color2,
        Color3,
        Color4
    }

    [RequireComponent(typeof(SpriteRenderer))]
    public class ColorController : MonoBehaviour
    {
        [SerializeField] private ColorScriptableObject _colors;
        [SerializeField] private ObjectColor _currentColor;
        [SerializeField] private bool _setRandomColorOnAwake = false;

        private SpriteRenderer _spriteRenderer;

        private void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            SetColor(_currentColor);

            if(_setRandomColorOnAwake) SetRandomColor();
        }

        private void SetColor(ObjectColor color)
        {
            _currentColor = color;
            gameObject.tag = _currentColor.ToString();

            if (_currentColor == ObjectColor.Color1) _spriteRenderer.color = _colors.color1;
            else if (_currentColor == ObjectColor.Color2) _spriteRenderer.color = _colors.color2;
            else if (_currentColor == ObjectColor.Color3) _spriteRenderer.color = _colors.color3;
            else _spriteRenderer.color = _colors.color4;
        }

        public void SetRandomColor()
        {
            SetColor((ObjectColor)Random.Range(0, 4));
        }
    }
}
