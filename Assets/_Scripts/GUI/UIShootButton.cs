using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.GUI
{
    public class UIShootButton : UIBaseButton
    {
        [SerializeField] private GameObject _plane;
        [SerializeField] private GameObject _rocket;

        public override void OnClick()
        {
            var rocket = Instantiate(_rocket);
            rocket.transform.position = _plane.transform.position;
        }
    }
}
