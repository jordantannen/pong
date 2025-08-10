using UnityEngine;

public class Computer : MonoBehaviour
{
    public float speed = 5f;
    public float maxY = 4f, minY = -4f;
    public Transform ball;
    
    private float waitTime = 0f;
    private float timer = 0f;
    public float responseTimeUpper = 1f;
    public float responseTimeLower = 0.01f;
    float targetY;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetY = transform.position.y;
        SetNextWait();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= waitTime)
        {
            if (ball != null)
                targetY = Mathf.Clamp(ball.position.y, minY, maxY);

            timer = 0f;
            SetNextWait();
        }
        
        float newY = Mathf.MoveTowards(transform.position.y, targetY, speed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }

    void SetNextWait()
    {
        waitTime = Random.Range(responseTimeLower, responseTimeUpper);
    }
}
