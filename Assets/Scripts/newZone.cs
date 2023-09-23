using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newZone : MonoBehaviour
{
    public GameObject Chest;
    public GameObject OpenChest;
    public GameObject player; 
    public Text KlickBite;
    public int trig = 0;
    private int trig2 = 0;



    // Start is called before the first frame update
    void Start()
    {
        OpenChest.SetActive(false);
        Chest.SetActive(true);
        trig = 0;
        KlickBite.text = "";
    }


    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, Chest.transform.position)<2)
        {
            KlickBite.text = "Pres E to respect";
            trig = 1;

        }
        if ((trig2 == 1) && (trig != 1))
        {
            trig2 = 0;
        }


        if (Vector3.Distance(player.transform.position, Chest.transform.position) > 2)
        {
            KlickBite.text = "";
            trig = 0;
        }

        if (trig == 1)
        {
            if (trig2==1)
            {
                KlickBite.text = "";
                OpenChest.SetActive(true);
                Chest.SetActive(false);

            }
        }
    }
    public void GetTrig2()
    {
        trig2 = 1;
    }
    public void DontGetTrig2()
    {
        trig2 = 0;
    }
}
