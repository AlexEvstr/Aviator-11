using Evstr.Score;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Evstr.GUI
{
    public class UIStartButton : UIBaseButton
    {
        [SerializeField] private Text _lastScoreText;
        [SerializeField] private Text _bestScoreText;
        private int _bestScore;
        private int _lastScore;

        private void Start()
        {
            _bestScore = PlayerPrefs.GetInt("Best Score");
            _bestScoreText.text = _bestScore.ToString();
            _lastScore = PlayerPrefs.GetInt("Last Score");
            _lastScoreText.text = _lastScore.ToString();
            Time.timeScale = 0;
        }

        public override void OnClick()
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1;
        }
    }
}
