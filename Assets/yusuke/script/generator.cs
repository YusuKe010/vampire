using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    [SerializeField] GameObject _enemy;
    GameObject _player;
    Vector3 _spownLocate;
    float _sponeTimer;
    [SerializeField] int _enemyVolume = 10;
    int _waveSave = 1;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        _sponeTimer += Time.deltaTime;

        if (_sponeTimer > 10.0f)
        {
            Debug.Log("スポーン");
            for (int i = 0; i < _enemyVolume; i++)
            {
                _spownLocate.x = Random.Range(_player.transform.position.x - 30, _player.transform.position.x + 30);
                _spownLocate.y = Random.Range(_player.transform.position.y - 20, _player.transform.position.y + 20);
                Instantiate(_enemy, _spownLocate, _enemy.transform.rotation);
            }
            _sponeTimer = 0;
        }

        if(GameManager._instance.Wave != _waveSave)
        {
            _waveSave += 1;
            Debug.Log($"ウェーブ{_waveSave}");
            _enemyVolume += 5;
        }
    }

}
