using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Rocket
{
    public class RocketMovement : MonoBehaviour
    {
        private float _speed = 25.0f;

        private void Update()
        {
            transform.Translate(Vector2.up * _speed * Time.deltaTime);
            if (transform.position.y > 6.0f)
            {
                Destroy(gameObject);
            }
        }
    }
}
