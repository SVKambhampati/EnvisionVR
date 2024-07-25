using UnityEngine;

public class PlayAudioOnInteraction : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        // Ensure the AudioSource component is assigned
        if (audioSource == null)
        {
            Debug.LogError("AudioSource is not assigned.");
        }
    }

    // Example of how you might detect interaction (replace with your detection logic)
    void Update()
    {
        // Example: Check if hand is in proximity or any other interaction condition
        if (IsInteractionDetected())
        {
            PlayAudio();
        }
    }

    bool IsInteractionDetected()
    {
        // Replace with your actual detection logic (e.g., hand proximity check)
        // Example: Check if hand is within a certain distance from an object
        // Example logic:
        // Vector3 handPosition = GetHandPosition();
        // Vector3 objectPosition = transform.position;
        // float distance = Vector3.Distance(handPosition, objectPosition);
        // return distance < interactionDistanceThreshold;

        // For demonstration, always return true (replace with actual logic)
        return true;
    }

    void PlayAudio()
    {
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}


