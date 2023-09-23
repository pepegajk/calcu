using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class islandcontroller : MonoBehaviour
{
    private float pereriv = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Spawn()
    {
        while(true)
        {
            yield return new WaitForSeconds(pereriv);
            for (int i = 0; i < 5; i++)
            { 
                this.transform.position += new Vector3(0, 0.05f, 0);
                yield return new WaitForSeconds(0.1f);
            }
            yield return new WaitForSeconds(pereriv);
            
            for (int j = 0; j < 5; j++)
            {
                    this.transform.position += new Vector3(0, -0.05f, 0);
                    yield return new WaitForSeconds(0.1f);
            }

            
        }
}   }
