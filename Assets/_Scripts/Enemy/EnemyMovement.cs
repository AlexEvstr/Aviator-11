using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Enemy
{
    public class EnemyMovement : MonoBehaviour
    {
        private float _speed = 5.0f;

        private void Update()
        {
            transform.Translate(Vector2.down * _speed * Time.deltaTime);
            if (transform.position.y < -7.0f)
            {
                Destroy(gameObject);
            }
        }
    }
}
