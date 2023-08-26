using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    private float mouseMovement;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        mouseMovement += Input.GetAxis("Mouse X");
        transform.localRotation = Quaternion.Euler(-90, 270, mouseMovement);
    }
}
