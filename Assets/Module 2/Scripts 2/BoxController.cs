using UnityEngine;

public class BoxController : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField]
    private float jumpForce = 5f; 

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Jump()
    {
        if (IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

 
    public void SetJumpForce(float newForce)
    {
        if (newForce > 0f)
        {
            jumpForce = newForce;
        }
    }

    public float GetJumpForce()
    {
        return jumpForce;
    }

    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 1.1f);
    }
}
