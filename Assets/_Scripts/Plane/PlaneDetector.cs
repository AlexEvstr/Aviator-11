using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Evstr.Score;

namespace Evstr.Plane
{
    public class PlaneDetector : MonoBehaviour
    {
        [SerializeField] private GameObject _gameOverPanel;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                _gameOverPanel.SetActive(true);
                Time.timeScale = 0;
            }
            else if (collision.gameObject.CompareTag("Fog"))
            {
                _gameOverPanel.SetActive(true);
                Time.timeScale = 0;
            }

            else if (collision.gameObject.CompareTag("Coin"))
            {
                ScoreIncrease.score += 15;
                Destroy(collision.gameObject);
            }
        }
    }
}
