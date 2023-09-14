using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private float _zeroMove = 0;

    private void Update()
    {
        transform.Rotate(_zeroMove, _rotationSpeed, _zeroMove);
    }
}