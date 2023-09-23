using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangebobaCont : MonoBehaviour

{
    public GameObject Brevno;
    private int t = 0;
    private float zadersh = 1.7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(this.transform.position, Brevno.transform.position)< 5.0f)
        {
            this.GetComponent<Animator>().SetTrigger("dead");
            t = 1; 
        }
        if (t == 1)
        {
            zadersh -= Time.deltaTime;
        }
        if (zadersh <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
