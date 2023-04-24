using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Enemy
{
    public class EnemySpawm : MonoBehaviour
    {
        [SerializeField] private GameObject _enemy;

        private float _yPosition = 8.0f;
        private float[] _xPosition = {-2.7f, -8f,  2.8f};
        private int _xIndex;

        private void Start()
        {
            StartCoroutine(Spawn());
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                _xIndex = Random.Range(0, _xPosition.Length);
                var enemy = Instantiate(_enemy);
                enemy.transform.position = new Vector2(_xPosition[_xIndex], _yPosition);
                yield return new WaitForSeconds(2);
            }
        }    
    }
}
