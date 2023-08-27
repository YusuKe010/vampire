using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] GameObject _bullet = null;
    [SerializeField] Transform[] _muzzles = null;
    [SerializeField] float _interval = 3f;

    float _timer = 0;

    void Start()
    {

    }

    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > _interval)
        {
            foreach (Transform t in _muzzles) 
            {
                Instantiate(_bullet, t.transform.position, t.transform.rotation);
                Debug.Log(t.position);
            }
            
            _timer = 0;
        }
    }
}
