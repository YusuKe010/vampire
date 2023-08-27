using System;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D)), RequireComponent(typeof(CircleCollider2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] int _nowHp;
    [SerializeField] PlayerDataBase _playerData;
    Rigidbody2D _rb;
    Transform _playerTransform;
    PlayerInput _playerInput;

    public int NowHp => _nowHp;

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
        _playerTransform = GetComponent<Transform>();
        _playerInput = GetComponent<PlayerInput>();
    }

    void Update()
    {
        PlayerMove();
        PlayerHp();
        PlayerScaleController();
    }

    void PlayerMove()
    {
        _rb.velocity = new Vector2(_playerInput.XInput, _playerInput.YInput).normalized;
        _rb.velocity *= _playerData.PlayerStatuses[0].MoveSpeed;
    }

    void PlayerHp()
    {
        _nowHp = _playerData.PlayerStatuses[0].MaxHp;
    }

    public void PlayerHeal(int value)
    {
        _nowHp += value;
    }

    void PlayerScaleController()
    {
        if (_playerInput.XInput == 1)
        {
            _playerTransform.localScale = new Vector2(-1, 1);
        }
        if (_playerInput.XInput == -1)
        {
            _playerTransform.localScale = new Vector2(1, 1);
        }
    }
}
