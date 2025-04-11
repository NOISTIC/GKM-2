using UnityEngine;

public class CameraActive : MonoBehaviour
{
    public Transform player;
    public Rigidbody checkIfBehind;
    public float speed = 0.125f;
    public Vector3 jarakCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 playerPosition = player.position + jarakCamera;

        Vector3 cameraPosition = Vector3.Lerp(transform.position, playerPosition, speed);

        transform.position = cameraPosition;
    }
}
