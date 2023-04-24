using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Coins
{
    public class CoinMovement : MonoBehaviour
    {
        private float _speed = 3.0f;

        private void Update()
        {
            transform.Translate(Vector2.down * _speed * Time.deltaTime);
        }
    }
}
