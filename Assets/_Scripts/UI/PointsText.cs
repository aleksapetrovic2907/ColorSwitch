using UnityEngine;
using TMPro;

namespace ColorSwitch.UI
{
    public class PointsText : MonoBehaviour
    {
        private TextMeshProUGUI _textMeshProUGUI;
        private void Awake()
        {
            _textMeshProUGUI = GetComponent<TextMeshProUGUI>();
            EventManager.current.onPointPickedUp += UpdateText;
        }

        private void UpdateText() => _textMeshProUGUI.text = GameManager.current.currentPoints.ToString();
    }
}
