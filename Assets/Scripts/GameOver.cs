using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public GameObject panelGameOver;
    public AudioClip[] voiceLines;
    private AudioSource audioSource;
    private bool hasPlayedVoiceLine = false;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        panelGameOver.SetActive(false);
    }
    void Update()
    {
        if (!hasPlayedVoiceLine && GameObject.FindGameObjectWithTag("Player") == null)
        {
            panelGameOver.SetActive(true);
            PlayRandomVoiceLine();
            hasPlayedVoiceLine = true;
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void PlayRandomVoiceLine()
    {
        if (voiceLines.Length > 0 && audioSource != null)
        {
            int randomIndex = Random.Range(0, voiceLines.Length);
            audioSource.PlayOneShot(voiceLines[randomIndex]);
        }
    }
}