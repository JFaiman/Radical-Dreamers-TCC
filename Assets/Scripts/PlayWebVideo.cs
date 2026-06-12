using UnityEngine;
using UnityEngine.Video;

public class PlayWebVideo : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, "TCC_INTRO_PLACEHOLDER.mp4");
        videoPlayer.Play();
    }
}