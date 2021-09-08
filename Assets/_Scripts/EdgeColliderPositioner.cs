using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ColorSwitch
{
    public class EdgeColliderPositioner : MonoBehaviour
    {
        [SerializeField] [Range(0f, 1f)] private float _viewportX = 0f;
        private void Awake()
        {
            transform.position = Camera.main.ViewportToWorldPoint(Vector3.right * _viewportX);
        }
    }
}
