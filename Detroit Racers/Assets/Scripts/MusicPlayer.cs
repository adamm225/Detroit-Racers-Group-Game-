using UnityEngine.UI;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    //song:
    public AudioSource mainSong;
    public Slider fader;
    private float musicVolume;

    void Start()
    {
        musicVolume = PlayerPrefs.GetFloat("volume");
        //Debug.Log(PlayerPrefs.GetFloat("volume"));
        fader.value = musicVolume;
        mainSong.volume = musicVolume;
        mainSong.Play();
    }

    void Update()
    {
        //Debug.Log(fader.value);
        //Debug.Log(mainSong.volume);
        mainSong.volume = fader.value;
        PlayerPrefs.SetFloat("volume", fader.value);
    }

    public void updateVolume(float volume ){
        fader.value = volume;
    }
}
