using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILookAtTheCamera : MonoBehaviour
{
    private Camera _mainCamera;
    private bool _hasCamera;

    private void Awake()
    {
        _mainCamera = Camera.main;
        _hasCamera = _mainCamera != null;
    }

    private void LateUpdate()
    {
        if (!_hasCamera) return;
        transform.LookAt(transform.position + _mainCamera.transform.rotation * Vector3.forward);
    }
}
