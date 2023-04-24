using System.Collections;
using System.Collections.Generic;
using Evstr.Score;
using UnityEngine;

namespace Evstr.Rocket
{
    public class RocketDetector : MonoBehaviour
    {
        [SerializeField] private GameObject _plus5;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
                Instantiate(_plus5);
                ScoreIncrease.score += 5;
            }
        }
    }
}
