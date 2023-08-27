using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batControllar : MonoBehaviour
{
    [SerializeField] float _speed = 1.0f;
    Rigidbody2D _rb;
    GameObject _player;
    [SerializeField] int _enemyHp = 3;
    [SerializeField] GameObject[] _item;

    float _damageTimer;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _player = GameObject.FindGameObjectWithTag("Player");
        if (_player.transform.position.x - this.transform.position.x < 0)
        {
            this.transform.localScale = new Vector3(-1 * this.transform.localScale.x, this.transform.localScale.y, this.transform.localScale.z); ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v = _player.transform.position - this.transform.position;
        v = v.normalized * _speed;
        _rb.velocity = v;
        if (_enemyHp <= 0)
        {
            Instantiate(_item[Random.Range(0,_item.Length)], this.gameObject.transform.position,this.gameObject.transform.rotation);
            Destroy(this.gameObject);
        }
        
    }
    public void WeponHit(int Damage)
    {
        _enemyHp -= Damage;
    }
}

