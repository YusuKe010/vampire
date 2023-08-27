using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "ScriptableObjects/CreatePlayerParamAsset")]
public class PlayerStatus : ScriptableObject
{
    [SerializeField] string _playerName = "test";
    [SerializeField] int _maxHp = 30;
    [SerializeField] float _attackDamage = 1;
    [SerializeField] float _moveSpeed = 5;
    [SerializeField] float _coolDown = 0;
    [SerializeField] float _deffence = 0;

    public string PlayerName => _playerName;
    public int MaxHp => _maxHp;
    public float AttackDamage => _attackDamage;
    public float MoveSpeed => _moveSpeed;
    public float CoolDown => _coolDown;
    public float Deffence => _deffence;
}
