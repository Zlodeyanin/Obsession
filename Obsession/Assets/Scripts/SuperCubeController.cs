using UnityEngine;

public class SuperCubeController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _increaseSpeed;

    private Vector3 _maxSize = new Vector3(2f, 2f);
    private Vector3 _returnOriginalSize = new Vector3(-1f, -1f);
    private float _zeroMove = 0;

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime, _zeroMove, _zeroMove);
        transform.Rotate(_zeroMove, _rotationSpeed, _zeroMove);

        if (transform.localScale.x < _maxSize.x)
        {
            transform.localScale += new Vector3(_increaseSpeed * Time.deltaTime, _increaseSpeed * Time.deltaTime);
        }
        else
        {
            transform.localScale += _returnOriginalSize;
        }
    }
}