using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    private float mouseMovement;

    void Awake()
    {
        mouseMovement = 0;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    { 
        mouseMovement = (Input.GetAxis("Mouse X") * 0.5f + mouseMovement) % 360;
        transform.localRotation = Quaternion.Euler(-90, 270, mouseMovement);
    }
}
