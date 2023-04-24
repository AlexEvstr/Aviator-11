using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Road
{
    public class RoadMovement : MonoBehaviour
    {
        private float _speed = 5.0f;

        private void Update()
        {
            transform.Translate(Vector2.down * _speed * Time.deltaTime);
        }
    }
}
