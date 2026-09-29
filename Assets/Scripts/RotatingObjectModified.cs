using UnityEngine;
using UnityEngine.InputSystem;

public class RotatingObstacleModified : MonoBehaviour
{
    public bool isActive = true; // Determines if the obstacle is active and should rotate
    public float rotationSpeed = 90f; // Speed of rotation in degrees per second
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("RoatingObstacle script has started.");
    }

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            isActive = !isActive; // Toggle the active state when the space key is pressed

        }
        transform.Rotate(

            0f, rotationSpeed * Time.deltaTime, 0f);
    }
}