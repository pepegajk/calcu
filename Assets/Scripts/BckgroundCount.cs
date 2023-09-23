using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BckgroundCount : MonoBehaviour
{
    public GameObject[] backgrounds;
    public GameObject player;
    public float CriticalDistance = 20.0f;
    public float MinCriticalDistance = 5.0f;
    public int trig = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y = player.transform.position.y; 
        backgrounds[0].transform.position += new Vector3( backgrounds[0].transform.position.x,y,  backgrounds[0].transform.position.z); 
        backgrounds[1].transform.position += new Vector3( backgrounds[1].transform.position.x,y,  backgrounds[1].transform.position.z);
        backgrounds[2].transform.position += new Vector3( backgrounds[2].transform.position.x,y,  backgrounds[2].transform.position.z);
    
        switch(trig)
        {
            case 1:
                if(Vector3.Distance(player.transform.position,backgrounds[0].transform.position)>CriticalDistance)
                {
                    if(Vector3.Distance(player.transform.position, backgrounds[1].transform.position) < MinCriticalDistance)
                    {
                        backgrounds[2].transform.position += new Vector3(-60f, 0, 0);
                        trig = 2;
                    }

                    if (Vector3.Distance(player.transform.position, backgrounds[2].transform.position) < MinCriticalDistance)
                    {
                        backgrounds[1].transform.position += new Vector3(60f, 0, 0);
                        trig = 3;
                    }

                }
            break;

            case 2:
                if (Vector3.Distance(player.transform.position, backgrounds[1].transform.position) > CriticalDistance)
                {
                    if (Vector3.Distance(player.transform.position, backgrounds[2].transform.position) < MinCriticalDistance)
                    {
                        backgrounds[0].transform.position += new Vector3(-60f, 0, 0);
                        trig = 3;
                    }

                    if (Vector3.Distance(player.transform.position, backgrounds[0].transform.position) < MinCriticalDistance)
                    {
                        backgrounds[2].transform.position += new Vector3(60f, 0, 0);
                        trig = 1;
                    }

                }
                break;

            case 3:
                    if (Vector3.Distance(player.transform.position, backgrounds[0].transform.position) < MinCriticalDistance)
                    {
                        backgrounds[1].transform.position += new Vector3(-60f, 0, 0);
                        trig = 1;
                    }

                    if (Vector3.Distance(player.transform.position, backgrounds[1].transform.position) < MinCriticalDistance)
                    {
                        backgrounds[0].transform.position += new Vector3(60f, 0, 0);
                        trig = 2;
                    }

                }
                break;
        }
    }
    public void GetTrig2()
    {
          if (Vector3.Distance(player.transform.position, backgrounds[0].transform.position) < MinCriticalDistance)
          {
          trig2 = 1;
          }
	}
     public void DontGetTrig2()
     {
          trig2 = 0;
          
	 }
}
