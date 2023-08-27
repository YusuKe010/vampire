using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    [SerializeField] GameObject _enemy;
    GameObject _player;
    float _worldTimer;
    Vector3 _spownLocate;
    int wave;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        _worldTimer = Time.deltaTime;
        if(wave == 0)
        {

            
            for (int i = 0; i < 10; i++)
            {
                _spownLocate.x = Random.Range(_player.transform.position.x - 200, _player.transform.position.x + 200);
                _spownLocate.y = Random.Range(_player.transform.position.y - 100, _player.transform.position.y + 100);
                Instantiate(_enemy, _spownLocate, _enemy.transform.rotation);
            }
            if(_worldTimer > 0)
            {

                wave = 1;
            }
            
        }
    }
}
