using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad = "Temple";
    public GameObject checkpointPrefab;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject checkpoint = Instantiate(checkpointPrefab, transform.position, Quaternion.identity);
            Checkpoint checkpointScript = checkpoint.GetComponent<Checkpoint>();
            checkpointScript.GetRespawnPosition();

            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
