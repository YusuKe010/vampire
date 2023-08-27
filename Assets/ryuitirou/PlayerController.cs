using UnityEngine;

[RequireComponent (typeof(Rigidbody2D)), RequireComponent(typeof(CircleCollider2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] int _nowHp;

    Rigidbody2D _rb;
    PlayerInput _playerInput;

    public static PlayerController Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _playerInput = GetComponent<PlayerInput>();
    }

    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        _rb.velocity = new Vector2(_playerInput.XInput, _playerInput.YInput).normalized;
        //_rb.velocity *= 
    }
}
