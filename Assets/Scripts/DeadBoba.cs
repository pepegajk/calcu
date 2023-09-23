using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAim : MonoBehaviour
{
    public GameObject boba;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) ;

  
        {
            boba.GetComponent<Animator>().SetTrigger("dead");
        }
    }
}
