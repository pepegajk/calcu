using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public GameObject Door;
    
    public GameObject player;
    public Text KlickBite;
    public int trig = 0;
    private int trig2 = 0;
    public string SceneName;



    // Start is called before the first frame update
    void Start()
    {
        
        Door.SetActive(true);
        trig = 0;
        KlickBite.text = "";
    }


    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, Door.transform.position) < 2)
        {
            KlickBite.text = "";
            trig = 1;

        }
        if ((trig2 == 1) && (trig != 1))
        {
            trig2 = 0;
        }


        if (Vector3.Distance(player.transform.position, Door.transform.position) > 2)
        {
            KlickBite.text = "";
            trig = 0;
        }

        if (trig == 1)
        {
            if (trig2 == 1)
            {
                KlickBite.text = "";
              SceneManagement.LoadScene(SceneName);
            }
        }
    }
    public void GetTrig2()
    {
        if (Vector3.Distance(player.transform.position, Door.transform.position) < 2f)
        {
            trig2 = 1;
        }

    }
    public void DontGetTrig2()
    {
        trig2 = 0;
    }
}