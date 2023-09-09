using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] private AudioSource deathSound;
    private bool isDead;

    private void Awake()
    {
        isDead = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Death();
        }
    }

    private void FixedUpdate()
    {
        if(transform.position.y <= -25 && !isDead)
        {
            Death();
        }
    }

    private void Death()
    {
        isDead = true;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<PlayerMovement>().enabled = false;
        GetComponent<MouseMovement>().enabled = false;
        deathSound.Play();

        Invoke(nameof(Respawn), 1.5f);
    }

    private void Respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
