using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionRestart : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle")) {  //if obstacle, then restart bc game over
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); }
    }
}
