using UnityEngine;
using UnityEngine.Audio;

public class UiAudioController : MonoBehaviour
{
    [SerializeField] AudioMixer myAudio;

    public void ChangeAudioVolume(float volume)
    {
        Debug.Log(volume);
        myAudio.SetFloat("Volume", volume);        
    }
    public void ChangeVolume(float volume)
    {
        float newVolume;
        newVolume = Mathf.Log10(volume) * 20;

        if (volume == 0)
        {
            newVolume = -80f;
        }
        myAudio.SetFloat("Volume", newVolume);
    }

    public void setFullScreen(bool fullScreen)
    {
        Screen.fullScreen = fullScreen;
    }
}
