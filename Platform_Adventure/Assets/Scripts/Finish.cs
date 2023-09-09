using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] private AudioSource finishSound;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            finishSound.Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
