using UnityEngine;

public class JumpPowerUp : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float jumpBoost;
    [SerializeField] private AudioSource collectSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collectSound.Play();
            player.GetComponent<PlayerMovement>().JumpForce += jumpBoost;
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<SphereCollider>().enabled = false;
            this.enabled = false;
        }
    }
}