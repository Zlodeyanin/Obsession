using UnityEngine;

public class CapsuleController : MonoBehaviour
{
    [SerializeField] private float _increaseSpeed;

    private Vector3 _maxSize = new Vector3(2f,2f);
    private Vector3 _returnOriginalSize = new Vector3(-1f, -1f);

    private void Update()
    {
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