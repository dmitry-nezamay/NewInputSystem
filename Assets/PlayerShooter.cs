using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class PlayerShooter : MonoBehaviour
{
    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = new PlayerInput();
        //_playerInput.Player.Shoot.performed += ctx => OnShoot();
        //_playerInput.Player.Move.performed += ctx => OnMove();
        //_playerInput.Player.Shoot.performed += ctx =>
        //{
        //    if (ctx.interaction is MultiTapInteraction)
        //        OnShoot();
        //};

        _playerInput.Player.Row.performed += ctx => 
        {
            if (ctx.interaction is SimpleInteraction)
                OnRow();
        };
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    public void OnShoot()
    {
        Debug.Log("Shoot");
    }

    private void OnRow()
    {
        Debug.Log("√–≈¡”");
    }

    private void OnMove()
    {
        //Vector2 direction = _playerInput.Player.Move.ReadValue<Vector2>();
        //Debug.Log(direction);
    }
}
