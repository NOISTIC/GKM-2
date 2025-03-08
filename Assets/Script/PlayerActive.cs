using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActive : MonoBehaviour
{
    private PlayerInput input;
    private InputAction moveAction;
    public float MovSpeed;
    //public Rigidbody rb;
    //public Vector2 movementDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        input = GetComponent<PlayerInput>();
        moveAction = input.actions.FindAction("Movement");
    }

    // Update is called once per frame
    void Update()
    {
        MovingCharacther();

    }

    public void MovingCharacther()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x * MovSpeed, 0, direction.y * MovSpeed) * Time.deltaTime;
    }
}
