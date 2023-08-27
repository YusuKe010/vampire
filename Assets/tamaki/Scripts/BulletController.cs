using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] float _bulletSpeed = 1f;
    [SerializeField] float _lifeTime = 10f;
    [SerializeField] int _hitDamage = 1;

    Rigidbody2D _rb = null;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        GameObject player = GameObject.FindWithTag("Player");

        if (player.transform.localScale.x <= 0)
        {
            _rb.velocity = Vector2.right * _bulletSpeed;
        }
        else
        {
            _rb.velocity = Vector2.left * _bulletSpeed;
        }

        Destroy(this.gameObject, _lifeTime);
    }

    private void Update()
    {    
        //Debug.Log(_rb.velocity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy") 
        {
            batControllar batcon = collision.GetComponent<batControllar>();
            batcon.WeponHit(_hitDamage);
        }     
    }
}
