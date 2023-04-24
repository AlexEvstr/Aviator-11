using System.Collections;
using System.Collections.Generic;
using Evstr.Score;
using UnityEngine;

namespace Evstr.Rocket
{
    public class RocketDetector : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
                ScoreIncrease.score += 5;
            }
        }
    }
}
