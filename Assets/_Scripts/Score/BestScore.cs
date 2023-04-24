using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Evstr.Score
{
    public class BestScore : MonoBehaviour
    {
        [SerializeField] private Text _bestScoreText;
        private int _bestScore;

        private void Start()
        {
            _bestScore = PlayerPrefs.GetInt("Best Score");
        }
        private void Update()
        {
            if (ScoreIncrease.score > _bestScore)
            {
                _bestScore = ScoreIncrease.score;
            }
            _bestScoreText.text = _bestScore.ToString();
        }

        private void OnDisable()
        {
            PlayerPrefs.SetInt("Best Score", _bestScore);
        }
    }
}
