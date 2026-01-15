using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            // start game again
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}