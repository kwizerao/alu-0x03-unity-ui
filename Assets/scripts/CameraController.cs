using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;

    private Vector3 CameraOffset = Vector3.zero;

    private void Start()
    {
        Player = GameObject.Find("Player");
        CameraOffset = transform.position - Player.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = Player.transform.position + CameraOffset;
    }
}