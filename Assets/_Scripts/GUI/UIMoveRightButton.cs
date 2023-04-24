using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.GUI
{
    public class UIMoveRightButton : UIBaseButton
    {
        [SerializeField] private GameObject _plane;

        public override void OnClick()
        {
            if (_plane.transform.position.x < 0)
            {
                _plane.transform.position = new Vector2(_plane.transform.position.x + 5.4f, _plane.transform.position.y);
            }
        }
    }
}
