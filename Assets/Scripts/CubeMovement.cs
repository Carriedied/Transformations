using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [SerializeField] private float _speedMovement;
    [SerializeField] private float _speedRotation;

    private void Update()
    {
        transform.Translate(Vector3.forward * _speedMovement * Time.deltaTime);
        transform.Rotate(Vector3.up * _speedRotation * Time.deltaTime);
    }
}
