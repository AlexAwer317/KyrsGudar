using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private Transform camTransform;
    private float shakeDur = 1f, shakeAmount = 0.04f, decreaseFactor = 1.5f;

    private Vector3 originPos;

//стартовая позиция камеры
    private void Start() {
        camTransform = GetComponent<Transform>();
        originPos = camTransform.localPosition;
    }


//тряска камеры
    private void Update() {
        if(shakeDur > 0) {
            camTransform.localPosition = originPos + Random.insideUnitSphere * shakeAmount;
            shakeDur -= Time.deltaTime * decreaseFactor;
        } else {
            shakeDur = 0;
            camTransform.localPosition = originPos;
        }
    }
}
