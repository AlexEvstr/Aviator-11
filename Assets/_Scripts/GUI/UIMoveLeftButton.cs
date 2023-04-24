using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.GUI
{
    public class UIMoveLeftButton : UIBaseButton
    {
        [SerializeField] private GameObject _plane;

        public override void OnClick()
        {
           if (_plane.transform.position.x > -3.0f)
            {
                _plane.transform.position = new Vector2(_plane.transform.position.x - 5.4f, _plane.transform.position.y);
            }
        }
    }
}
