using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    GameObject[] pause;
    private AudioSource audioSrc1;
    private float musicVolume2 = 1f;
    // Start is called before the first frame update
    void Start()
    {
        audioSrc1 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSrc1.volume = musicVolume2;
    }
    public void SetVolume2(float vol)
    {
        musicVolume2 = vol;
    }
    public void SetMute2()
    {
        AudioListener.pause = !AudioListener.pause;  
    }
}
