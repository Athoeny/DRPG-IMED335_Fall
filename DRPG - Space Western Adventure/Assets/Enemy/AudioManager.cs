using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
#pragma warning disable IDE0051

    [Header("-------- Audio Sources --------")]
    [SerializeField] AudioSource SFXSource;

    [Header("-------- Audio Clips --------")]

    public AudioClip EnemyTeleport1;
    public AudioClip EnemyTeleport2;

    public void PlaySFX(AudioClip clip, float volume = 1.0f)
    {
        SFXSource.PlayOneShot(clip, volume);
    }
}