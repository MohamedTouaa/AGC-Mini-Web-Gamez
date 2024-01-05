using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float moveSpeed = 5f;
    public Animator animator;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 moveDirection = new Vector2(horizontal, vertical);

        rb2d.velocity = moveDirection * moveSpeed;

        // Update animation based on direction
        if (moveDirection.x > 0)
        {
            animator.SetBool("MovingRight", true);
        }
        else if (moveDirection.x < 0)
        {
            animator.SetBool("MovingLeft", true);
        }
        else
        {
            animator.SetBool("MovingRight", false);
            animator.SetBool("MovingLeft", false);
        }

        if (moveDirection.y > 0)
        {
            animator.SetBool("MovingUp", true);
        }
        else if (moveDirection.y < 0)
        {
            animator.SetBool("MovingDown", true);
        }
        else
        {
            animator.SetBool("MovingUp", false);
            animator.SetBool("MovingDown", false);
        }
    }
}
