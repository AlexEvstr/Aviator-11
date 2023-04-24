using UnityEngine;
using UnityEngine.SceneManagement;

namespace Evstr.GUI
{
    public class UIStartButton : UIBaseButton
    {
        private void Start()
        {
            Time.timeScale = 0;
        }

        public override void OnClick()
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1;
        }
    }
}
