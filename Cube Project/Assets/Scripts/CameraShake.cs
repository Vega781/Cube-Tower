using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private Transform camTransform;
    private float shakeDuration = 1f, shakeAmount = 0.03f, decreaseFactor = 1.5f;

    private Vector3 originPosition;

    private void Start()
    {
        camTransform = GetComponent<Transform>();
        originPosition = camTransform.localPosition;
    }

    private void Update()
    {
        if(shakeDuration > 0)
        {
            camTransform.localPosition = originPosition + Random.insideUnitSphere * shakeAmount;
            shakeDuration -= Time.deltaTime * decreaseFactor;
        }
        else
        {
            shakeDuration = 0;
            camTransform.localPosition = originPosition;
        }
    }
}
