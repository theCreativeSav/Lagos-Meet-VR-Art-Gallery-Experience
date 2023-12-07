using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    public AudioSource bgMusicSource;
    public AudioSource cubicleMusicSource1;
    public AudioSource cubicleMusicSource2;
    public AudioSource cubicleMusicSource3;
    public AudioSource cubicleMusicSource4;

    public bool isInElder = false;
    public bool isInSpiritual = false;
    public bool isInPhotography = false;
    public bool isInBillboard = false;
    public bool isInBg = true;

    public float vol1 = 0f;
    public float vol2 = 0f;
    public float vol3 = 0f;
    public float vol4 = 0f;
    public float volBg = 0.6f;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ElderSoundBox")
        {
            isInElder = true;
            isInBg = false;
        }
        else if (other.gameObject.tag == "SpiritualSoundBox")
        {
            isInSpiritual = true;
            isInBg = false;
        }
        else if (other.gameObject.tag == "PhotographySoundBox")
        {
            isInPhotography = true;
            isInBg = false;
        }
        else if (other.gameObject.tag == "BillboardSoundBox")
        {
            isInBillboard = true;
            isInBg = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ElderSoundBox")
        {
            
        }
        else if (other.gameObject.tag == "SpiritualSoundBox")
        {
        }
        else if (other.gameObject.tag == "PhotographySoundBox")
        {
        }
        else if (other.gameObject.tag == "BillboardSoundBox")
        {

        }
    }



    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ElderSoundBox")
        {         
            isInElder = false;
            isInBg = true;
        }
        else if (other.gameObject.tag == "SpiritualSoundBox")
        {
            isInSpiritual = false;
            isInBg = true;

        }
        else if (other.gameObject.tag == "PhotographySoundBox")
        {
            isInPhotography = false;
            isInBg = true;
        }
        else if (other.gameObject.tag == "BillboardSoundBox")
        {
            isInBillboard = false;
            isInBg = true;
        }
    }


    private void Update()
    {
        if (isInBg)
        {
            if (volBg < 0.6f)
            {
                volBg += 0.0036f;
            }
            bgMusicSource.volume = volBg;
        }
        else
        {
            if (volBg > 0f)
            {
                volBg -= 0.0036f;
            }
            bgMusicSource.volume = volBg;
        }


        if (isInElder)
        {
            if (vol1 < 0.6f)
            {
                vol1 += 0.0036f;
            }
            cubicleMusicSource1.volume = vol1;

        }
        else
        {
            if (vol1 > 0f)
            {
                vol1 -= 0.0036f;
            }
            cubicleMusicSource1.volume = vol1;

            
        }

        if (isInSpiritual)
        {
            if (vol2 < 0.6f)
            {
                vol2 += 0.0036f;
            }
            cubicleMusicSource2.volume = vol2;

        }
        else
        {
            if (vol2 > 0f)
            {
                vol2 -= 0.0036f;
            }
            cubicleMusicSource2.volume = vol2;

        }

        if (isInPhotography)
        {
            if (vol3 < 0.6f)
            {
                vol3 += 0.0036f;
            }
            cubicleMusicSource3.volume = vol3;

        }
        else
        {
            if (vol3 > 0f)
            {
                vol3 -= 0.0036f;
            }
            cubicleMusicSource3.volume = vol3;

        }

        if (isInBillboard)
        {
            if (vol4 < 0.6f)
            {
                vol4 += 0.0036f;
            }
            cubicleMusicSource4.volume = vol4;


        }
        else
        {
            if (vol4 > 0f)
            {
                vol4 -= 0.0036f;
            }
            cubicleMusicSource4.volume = vol4;

        }
    }


}
