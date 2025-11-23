using UnityEngine;
using UnityEngine.SceneManagement;

public class finishLine : MonoBehaviour
{
    [SerializeField] string winSceneName = "WinScene";
    [SerializeField] string loseSceneName = "LoseScene";

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D called with: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player won");
            SceneManager.LoadScene(winSceneName);
        }
        else if (other.CompareTag("Enemy"))
        {
            Debug.Log("Enemy won");
            SceneManager.LoadScene(loseSceneName);
        }
    }
}
