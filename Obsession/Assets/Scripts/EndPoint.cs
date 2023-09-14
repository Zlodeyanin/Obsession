using UnityEngine;

public class EndPoint : MonoBehaviour
{
    public Vector2 Vector2 { get; private set; }

    private void Start()
    {
        Vector2= transform.position;
    }
}