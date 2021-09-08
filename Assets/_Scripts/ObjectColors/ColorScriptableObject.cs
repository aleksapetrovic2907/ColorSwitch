using UnityEngine;

namespace ColorSwitch.ObjectColors
{
    [CreateAssetMenu(fileName = "Colors", menuName = "ScriptableObjects/Colors")]
    public class ColorScriptableObject : ScriptableObject
    {
        public Color32 color1;
        public Color32 color2;
        public Color32 color3;
        public Color32 color4;
    }
}
