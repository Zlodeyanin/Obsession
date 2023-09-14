using UnityEngine;

public class SphereController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] EndPoint _endPoint;

    private Vector2 _startPosition;
    private float _zeroMove = 0;

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        if (transform.position.x > _endPoint.Vector2.x)
        {
            transform.Translate(_startPosition.x * 2, _zeroMove, _zeroMove);
        }
        else
        {
            transform.Translate(_speed * Time.deltaTime, _zeroMove, _zeroMove);
        }
    }
}