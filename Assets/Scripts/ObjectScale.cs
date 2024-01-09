using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScale : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private float _finalSize;

    private bool _isIncreaseScale;
    private float _initialSize;

    private void Start()
    {
        _initialSize = transform.localScale.x;
    }

    private void Update()
    {
        float newScaleX;
        float newScaleY;
        float newScaleZ;

        if (transform.localScale.x <= _initialSize + 0.1)
        {
            _isIncreaseScale = true;
        }

        if (_isIncreaseScale)
        {
            newScaleX = Mathf.Lerp(transform.localScale.x, _finalSize, _scaleSpeed * Time.deltaTime);
            newScaleY = Mathf.Lerp(transform.localScale.y, _finalSize, _scaleSpeed * Time.deltaTime);
            newScaleZ = Mathf.Lerp(transform.localScale.z, _finalSize, _scaleSpeed * Time.deltaTime);

            transform.localScale = new Vector3(newScaleX, newScaleY, newScaleZ);
        }

        if (transform.localScale.x >= _finalSize - 0.1)
        {
            _isIncreaseScale = false;
        }

        if (_isIncreaseScale == false)
        {
            newScaleX = Mathf.Lerp(transform.localScale.x, _initialSize, _scaleSpeed * Time.deltaTime);
            newScaleY = Mathf.Lerp(transform.localScale.y, _initialSize, _scaleSpeed * Time.deltaTime);
            newScaleZ = Mathf.Lerp(transform.localScale.z, _initialSize, _scaleSpeed * Time.deltaTime);

            transform.localScale = new Vector3(newScaleX, newScaleY, newScaleZ);
        }
    }
}
