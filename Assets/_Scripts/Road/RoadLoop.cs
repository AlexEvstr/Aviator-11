using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Road
{
    public class RoadLoop : MonoBehaviour
    {
        private void Update()
        {
            if (transform.position.y < -11.0f)
            {
                transform.position = new Vector2(0, 13.4f);
            }
        }
    }
}
