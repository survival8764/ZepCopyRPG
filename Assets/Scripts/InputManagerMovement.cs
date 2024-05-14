using UnityEngine;

public class InputManagerMovement : MonoBehaviour
{
    Rigidbody2D rdbody;

    [SerializeField] private float speed;
    
    void Start()
    {
        rdbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");

        Vector2 direction = new Vector2(horizontal, vertical);
        direction = direction.normalized;

        rdbody.velocity = direction * speed;
    }
}
