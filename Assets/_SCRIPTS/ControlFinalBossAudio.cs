using UnityEngine;

public class ControlFinalBossAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip newSoundtrack; 

    public void PlayNewSoundtrack()
    {
        if (audioSource.isPlaying)
            audioSource.Stop();  // Stop the current audio if any is playing

        audioSource.clip = newSoundtrack; // Set the new audio clip
        audioSource.Play(); // Play the new soundtrack
    }
}
