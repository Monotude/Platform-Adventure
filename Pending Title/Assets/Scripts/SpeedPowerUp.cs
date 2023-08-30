using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float speedBoost;
    [SerializeField] private AudioSource collectSound;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collectSound.Play();
            player.GetComponent<PlayerMovement>().MovementSpeed += speedBoost;
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<SphereCollider>().enabled = false;
            this.enabled = false;
        }
    }
}
