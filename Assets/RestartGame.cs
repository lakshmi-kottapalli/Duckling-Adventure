using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
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