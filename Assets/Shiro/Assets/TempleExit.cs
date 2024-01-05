using UnityEngine;
using UnityEngine.SceneManagement;

public class TempleExit : MonoBehaviour
{
    public string exitScene = "Main";
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player position before respawn: " + player.transform.position);

            // Delay the respawn by a short time to ensure the correct position is set
            Invoke("Respawn", 0.1f);
        }
    }

    private void Respawn()
    {
        // Set the player position to the last checkpoint's position
        player.transform.position = GameManager.instance.lastCheckpointPosition;

        Debug.Log("Player position after respawn: " + player.transform.position);

        SceneManager.LoadScene(exitScene);
    }
}
