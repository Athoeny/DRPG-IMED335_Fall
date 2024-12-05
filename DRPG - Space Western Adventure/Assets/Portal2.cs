using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportOnTouch : MonoBehaviour
{
    // Set this to the name of the scene to load
    [SerializeField] private string targetScene;

    public string HubWorld2 { get; private set; }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object entering the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Load the specified scene
            SceneManager.LoadScene("HubWorld2");
        }
    }
}