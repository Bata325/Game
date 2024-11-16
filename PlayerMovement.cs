using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 5f;
    public Rigidbody2D rigidbody;
    Vector2 movement;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("horizontal", movement.x);
        animator.SetFloat("vertical",movement.y);
        animator.SetFloat("movespeed",movement.sqrMagnitude);

    }

    void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + movement * speed * Time.fixedDeltaTime);

    }

}
