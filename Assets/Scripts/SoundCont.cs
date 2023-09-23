using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCont : MonoBehaviour
{
    public AudioSource au;
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;
    public float time1= 182.0f;
    public float time2= 10.0f;
    public float time3= 10.0f;
    public float time4= 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Control());
    }

     IEnumerator Control()
    {
        yield return new WaitForSeconds(0.0f);
        while(true)
        {
            au.PlayOneShot(clip1);
            yield return new WaitForSeconds(time1);
            au.PlayOneShot(clip2);
            yield return new WaitForSeconds(time2);
            au.PlayOneShot(clip3);
            yield return new WaitForSeconds(time3);
            au.PlayOneShot(clip4);
            yield return new WaitForSeconds(time4);
        }
    }
 
}
