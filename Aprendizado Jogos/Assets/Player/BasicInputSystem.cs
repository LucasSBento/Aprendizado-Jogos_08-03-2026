using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float jumpForce;
    public float vel;
    public Rigidbody2D rb;
    public Vector2 vector;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        vector = context.ReadValue<Vector2>();
    }

    public void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(vector.x * vel, rb.linearVelocity.y);
    }
}
