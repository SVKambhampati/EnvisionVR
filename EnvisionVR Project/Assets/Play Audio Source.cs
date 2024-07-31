using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    public AudioSource audioSource;

    public void PlayAudio()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
