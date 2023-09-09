using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    private float mouseMovement;
    [SerializeField] private float mouseSensitivity;

    void Awake()
    {
        mouseMovement = 270;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    { 
        mouseMovement = (Input.GetAxis("Mouse X") * mouseSensitivity + mouseMovement) % 360;
        transform.localRotation = Quaternion.Euler(0, mouseMovement, 0);
    }
}
