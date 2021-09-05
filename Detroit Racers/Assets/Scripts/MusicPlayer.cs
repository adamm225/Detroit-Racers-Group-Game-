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
        Debug.Log(PlayerPrefs.GetFloat("volume"));

        if (fader != null)
        {
            fader.value = musicVolume;
            mainSong.volume = musicVolume;
        }
    }

    void Update()
    {
        //Debug.Log(fader.value);
        //Debug.Log(mainSong.volume);
        if (fader != null)
        {
            mainSong.volume = fader.value;
            PlayerPrefs.SetFloat("volume", fader.value);
        }
    }

    public void updateVolume(float volume ){
        fader.value = volume;
    }
}
