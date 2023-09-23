using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrapDead : MonoBehaviour
{
    public GameObject player;
    public GameObject trap;
    public Text nadpis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, trap.transform.position) < 2.0f)
        {
            nadpis.text = "ЛОООООООООХ!!!!!";
        }

    }
}
