using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] GameObject _bullet = null;
    [SerializeField] float _interval = 3f;

    float _timer = 0;

    void Start()
    {

    }

    void Update()
    {
        _timer = Time.deltaTime;

        if (_timer > _interval)
        {
            Instantiate(_bullet, this.transform.position, Quaternion.identity);
            _timer = 0;
        }
    }
}
