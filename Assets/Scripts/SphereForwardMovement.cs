using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _startPosition;
    private bool _isMovingForward = true;

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        Vector3 currentPosition = transform.position;
        Vector3 screenPosition = Camera.main.WorldToViewportPoint(transform.position);
        Vector3 targetPosition;

        if (screenPosition.x < 1 || screenPosition.x > 0 || screenPosition.y < 1 || screenPosition.y > 0 && _isMovingForward == true)
        {
            targetPosition = currentPosition + new Vector3(0f, 0f, -1f);
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, _speed * Time.deltaTime);

        }

        if (_isMovingForward == false)
        {
            targetPosition = currentPosition + new Vector3(0f, 0f, 0.001f);
            transform.position = Vector3.MoveTowards(targetPosition, _startPosition, _speed * Time.deltaTime);
        }

        if (transform.position.z >= _startPosition.z)
        {
            _isMovingForward = true;
        }

        if (screenPosition.x < 0 || screenPosition.x > 1 || screenPosition.y < 0 || screenPosition.y > 1)
        {
            _isMovingForward = false;
        }
    }
}
