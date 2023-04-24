using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Evstr.Score;

namespace Evstr.Plane
{
    public class PlaneDetector : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                Debug.Log("Game Over");
            }
            else if (collision.gameObject.CompareTag("Fog"))
            {
                Debug.Log("Game Over");
            }

            else if (collision.gameObject.CompareTag("Coin"))
            {
                ScoreIncrease.score += 15;
                Destroy(collision.gameObject);
            }
        }
    }
}
