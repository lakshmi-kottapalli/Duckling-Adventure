using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Camera titleCamera;       //starting view
    public Camera gameplayCamera;    // game camera
    public float transitionSpeed = 1.2f;

    private bool transitioning = false;
    private float t = 0;

    void Start()
    {
        // Start with title camera active, gameplay camera off
        titleCamera.enabled = true;
        gameplayCamera.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            transitioning = true;

        if (transitioning)
        {
            t += Time.deltaTime * transitionSpeed;

            
            titleCamera.transform.position = Vector3.Lerp(
                titleCamera.transform.position,
                gameplayCamera.transform.position,
                t
            );

            titleCamera.transform.rotation = Quaternion.Lerp(
                titleCamera.transform.rotation,
                gameplayCamera.transform.rotation,
                t
            );

           
            if (t >= 1f)
            {
                titleCamera.enabled = false;
                gameplayCamera.enabled = true;
                transitioning = false;
            }
        }
    }
}
