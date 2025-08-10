using UnityEngine;

public class Computer : MonoBehaviour
{
    public float speed = 5f;
    public float maxY = 4f, minY = -4f;
    public Transform ball;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float targetY = Mathf.Clamp(ball.position.y, minY, maxY);
        float newY = Mathf.MoveTowards(transform.position.y, targetY, speed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
