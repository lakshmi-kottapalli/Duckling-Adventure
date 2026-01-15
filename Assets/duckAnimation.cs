using UnityEngine;

public class DuckAnimationController : MonoBehaviour
{
    public Animation duckAnimation;

    public string rwingClipName = "rwingAction";
    public string lwingClipName = "lwingAction";
    public string headClipName = "headAction";

    void Start()
    {
        // Set all clips to loop
        duckAnimation[rwingClipName].wrapMode = WrapMode.Loop;
        duckAnimation[lwingClipName].wrapMode = WrapMode.Loop;
        duckAnimation[headClipName].wrapMode = WrapMode.Loop;

        // Play all clips at the same time
        duckAnimation.Play(rwingClipName);
        duckAnimation.Play(lwingClipName);
        duckAnimation.Play(headClipName);
    }
}

