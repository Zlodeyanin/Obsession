using UnityEngine;

public class SphereController : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector2 _endPosition = new Vector2(8f, 0f);
    private Vector2 _startPosition;
    private float _zeroMove = 0;

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        if (transform.position.x > _endPosition.x)
        {
            transform.Translate(_startPosition.x * 2, _zeroMove, _zeroMove);
        }
        else
        {
            transform.Translate(_speed * Time.deltaTime, _zeroMove, _zeroMove);
        }
    }
}