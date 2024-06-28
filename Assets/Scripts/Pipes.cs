using UnityEngine;

public class Pipes : MonoBehaviour
{
    public Transform Top;
    public Transform Bottom;
    public float speed = 5f;
    public float gap = 3f;

    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
        Top.position += Vector3.up * gap / 2;
        Bottom.position += Vector3.down * gap / 2;
    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        
        if(transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
