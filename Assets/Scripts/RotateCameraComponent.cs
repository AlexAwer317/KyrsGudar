using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCameraComponent : MonoBehaviour
{
    public float _speed = 5f;
    private Transform _rotatetor;

    private void Start() {
        _rotatetor = GetComponent<Transform>();
    }
    private void Update() {
        _rotatetor.Rotate(0, _speed* Time.deltaTime, 0);
    }
}
