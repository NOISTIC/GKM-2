using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActive : MonoBehaviour
{
    [Header("Movement")]
    public float MovSpeed;
    public float RotSpeed;
    private Rigidbody rb;
    public float JumpForce;
    public bool isGrounded = true;
    public int amountofJumps;
    public int amountofJumpsLeft = 2;

    [Header("Falling")]
    public float fallAcceleration = 9.81f;
    public float fallSpeed;

    [Header("Attacking")]
    public AttackCheck attackChecker;
    //public float AttackCooldown = 5f;
    //private float nextAttackTime;
    //public GameObject check;
    //public Rigidbody rb;
    //public Vector2 movementDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(isGrounded)
        {
            jumping();
        }

        StartCoroutine(Attacking());
    }

    private void FixedUpdate()
    {
        MovingCharacther();
        if (rb.linearVelocity.y < 0)
        {
            fallSpeed += fallAcceleration * Time.deltaTime;
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, -fallSpeed, rb.linearVelocity.z);
        }
        else
        {
            fallSpeed = 0;
        }
    }
    public void MovingCharacther()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveX, 0f, moveZ).normalized * MovSpeed;
        rb.MovePosition(transform.position + movement * Time.deltaTime);

        if(movement != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * RotSpeed);
        }
    }

    public void jumping()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if(isGrounded || amountofJumps > amountofJumpsLeft)
            {
                rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
                amountofJumps++;
                if (amountofJumps > amountofJumpsLeft)
                {
                    isGrounded = true;
                }
                else if (amountofJumps == amountofJumpsLeft)
                {
                    isGrounded = false;
                }
            }
            
        }
        
    }

    public IEnumerator Attacking()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            attackChecker.attackCheck.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            attackChecker.attackCheck.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            amountofJumps = 0;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Mati");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            
        }
    }
}
