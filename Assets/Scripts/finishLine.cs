using UnityEngine;
using UnityEngine.SceneManagement;

public class finishLine : MonoBehaviour
{
    private string nextSceneName = "WinScene";

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D called with: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player reached the finish line!");
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
