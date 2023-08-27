using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] float _xInput;
    [SerializeField] float _yInput;
    
    public float XInput => _xInput;
    public float YInput => _yInput;

    void Update()
    {
        PlayerController();
    }

    void PlayerController()
    {
        _xInput = Input.GetAxisRaw("Horizontal");
        _yInput = Input.GetAxisRaw("Vertical");
    }
}
