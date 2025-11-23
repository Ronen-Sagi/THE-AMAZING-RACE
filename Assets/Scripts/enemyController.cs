using UnityEngine;

public class enemyController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f;
    
    [SerializeField] Transform[] movePoints;
    private int currIdx = 0;
    
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (movePoints == null || movePoints.Length == 0) return;
        
        Vector2 target = movePoints[currIdx].position;
        Vector2 dirr = (target - rb.position).normalized;
        
        rb.linearVelocity = dirr * moveSpeed;

        if (Vector2.Distance(target, rb.position) < 0.1f)
        {
            currIdx++;
            if (currIdx >= movePoints.Length)
            {
                currIdx = 0;
            }
        }
        
    }
}
