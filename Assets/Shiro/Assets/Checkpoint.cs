using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.lastCheckpointPosition = transform.position;
            Debug.Log("Checkpoint activated at: " + transform.position);
        }
    }

    public Vector3 GetRespawnPosition()
    {
        return GameManager.instance.lastCheckpointPosition;
    }
}
