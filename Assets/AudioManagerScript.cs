using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{

    public AudioSource bgMusicSource;
    public AudioSource cubicleMusicSource;
    public AudioClip elderAudioClip;
    public AudioClip spiritualAudioClip;
    public AudioClip photographyAudioClip;
    public AudioClip billboardAudioClip;
    public AudioClip bgAudioClip;    



    // Start is called before the first frame update
    void Start()
    {
        bgMusicSource.clip = bgAudioClip;
        bgMusicSource.Play();

        //cubicleMusicSource.clip = elderAudioClip;
        //cubicleMusicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
