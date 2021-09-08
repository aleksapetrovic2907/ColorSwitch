using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ColorSwitch
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Transform _player;
        [SerializeField] private float _followSpeed;

        private void Update()
        {
            FollowPlayer();
        }

        private void FollowPlayer()
        {
            if (_player != null && _player.position.y > transform.position.y)
            {
                var _zOffset = new Vector3(0f, 0f, -10f);
                var targetPosition = (Vector3)Vector2.Lerp(transform.position, _player.position, _followSpeed * Time.deltaTime) + _zOffset;
                
                transform.position = targetPosition;
            }
        }
    }
}
