using UnityEngine;
using UnityEngine.InputSystem;

public class WaterWheel : MonoBehaviour
{
    public float rotationSpeed = 90f; // Speed of rotation in degrees per second
    public bool isActive = true; // Determines if the water wheel is active and should rotate

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame) // Toggle the active state when the space key is pressed
            isActive = !isActive; // Toggle the active state when the space key is pressed

        if (isActive) // Rotate the water wheel if it is active
            transform.Rotate(rotationSpeed * Time.deltaTime, 0f, 0f); // Rotate around the x-axis
    }
}