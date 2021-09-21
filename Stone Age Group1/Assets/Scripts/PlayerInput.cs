using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerInput : MonoBehaviour
{ 
    private static PlayerInput pm;
    

    [Header("Player Property")]
    [SerializeField] private float playerSpeed;
    [SerializeField] private float playerJumpForce;
    [SerializeField] private Transform root;
    [SerializeField] private Weapon weapon;
    [SerializeField] private float hitDelay;
    [SerializeField] private float raycastDistance;
    [SerializeField] private LayerMask layer;

    public static Vector3 Position { get => pm.transform.position; set { pm.transform.position = value; } }

    private float currentPlayerSpeed;
    private Rigidbody2D rb;

    private bool isGrounded;
    private bool isRight = true;
    private bool canHit = true;

    private void Awake()
    {
        pm = this;
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(currentPlayerSpeed * Time.deltaTime, rb.velocity.y);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, raycastDistance,layer.value );
        isGrounded = hit.collider != null;

    }
    public void RightMove()
    {
        Animations.SetBool("moving", true);
        currentPlayerSpeed = playerSpeed;
        if (!isRight)
        {
            Flip();
            isRight = true;
        }
        //transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z) ;
    }
    public void LeftMove()
    {
        Animations.SetBool("moving", true);
        currentPlayerSpeed = -playerSpeed;
        if (isRight)
        {
            Flip();
            isRight = false;
        }

        //transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }
    public void Jump()
    {
        if (isGrounded)
        {
            isGrounded = false;
            rb.AddForce(transform.up * playerJumpForce, ForceMode2D.Impulse);
            //rb.velocity = new Vector2(rb.velocity.x, playerJumpForce);
            Animations.SetTrigger("jump");

        }

    }
    public void Attack()
    {
        if (canHit)
        {
            StartCoroutine(HitDelay());
            weapon.Hit();
            Animations.SetTrigger("attack"); 
        }
    }
    public void StopMove()
    {
        currentPlayerSpeed = 0f;
        Animations.SetBool("moving", false);
        //transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }
    private void Flip()
    {
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
   private IEnumerator HitDelay()
    {
        canHit = false;
        yield return new WaitForSeconds(hitDelay);
        canHit = true;

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * raycastDistance);  
    }
    public static void Disable()
    {
        pm.enabled = false;
    }
    public static void Enable()
    {
        pm.enabled = true;
    }
}
