using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobaSound : MonoBehaviour
{
public Audiospurs au;
private float DistanceCrit = 30.0f;
public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distaince(Player.transform.positiont , this.transform.position)<DistanceCrit)
        {
         au.Play();
		}
         if(Vector3.Distaince(Player.transform.positiont , this.transform.position)<DistanceCrit)
        {
         au.Stop();
		}
    }
}
