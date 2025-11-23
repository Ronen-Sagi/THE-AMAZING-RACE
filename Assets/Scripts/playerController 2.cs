using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    
    [SerializeField] private InputAction up = new InputAction(type: InputActionType.Button);
    [SerializeField] private InputAction down = new InputAction(type: InputActionType.Button);
    [SerializeField] private InputAction left = new InputAction(type: InputActionType.Button);
    [SerializeField] private InputAction right = new InputAction(type: InputActionType.Button);
    
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        up.Enable();
        down.Enable();
        left.Enable();
        right.Enable();
    }
    
    private void OnDisable()
    {
        up.Disable();
        down.Disable();
        left.Disable();
        right.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        float x = 0f;
        float y = 0f;
        
        if (up.IsPressed())
        {
            y += 1f;
        }
        if (down.IsPressed())
        {
            y -= 1f;
        }

        if (right.IsPressed())
        {
            x += 1f;
        }
        if (left.IsPressed())
        {
            x -= 1f;
        }
        
        Vector2 playerDirect = new Vector2(x, y).normalized;
        rb.linearVelocity = playerDirect * speed;

    }
}
