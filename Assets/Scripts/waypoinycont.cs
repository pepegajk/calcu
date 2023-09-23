using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoinycont : MonoBehaviour
{ 
    public float moveSpeed = 3.0f;
    public float jumpSpeed = 10.0f;
    public GameObject monster;
    public GameObject waypoint;
    public int trig = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float move = moveSpeed * Time.deltaTime;
        float moveJump = jumpSpeed * Time.deltaTime;
        Vector3 delta1 = waypoint [0].transform.position - monster.transform.position;
        Vector3 delta2 = waypoint [0].transform.position - monster.transform.position;
        Vector3 delta3 = waypoint [0].transform.position - monster.transform.position;
        Vector3 delta4 = waypoint [0].transform.position - monster.transform.position;
        Vector3 delta5 = waypoint [0].transform.position - monster.transform.position;
        Vector3 delta6 = waypoint [0].transform.position - monster.transform.position;
        Vector3 delta7 = waypoint [0].transform.position - monster.transform.position;
        Vector3 delta8 = waypoint [0].transform.position - monster.transform.position;
        Vector3 delta9 = waypoint [0].transform.position - monster.transform.position;

        delta1.Normalize ();
        delta2.Normalize ();
        delta3.Normalize ();
        delta4.Normalize ();
        delta5.Normalize ();
        delta6.Normalize ();
        delta7.Normalize ();
        delta8.Normalize ();
        delta9.Normalize ();
        delta10.Normalize ();

        {
        case 1; 
        monster.transform.position += move * delta1;
        if(Vector3.Distance(monster.transform.position , waypoint [0].transform.position)< 0.4f)
        {
        trig = 2;
		}
        break;
          case 2; 
        monster.transform.position += move * delta2;
        if(Vector3.Distance(monster.transform.position , waypoint [1].transform.position)< 0.4f)
        {
        trig = 3;
		}
        break;
          case 3; 
        monster.transform.position += move * delta3;
        if(Vector3.Distance(monster.transform.position , waypoint [2].transform.position)< 0.4f)
        {
        trig = 4;
		}
        break;
          case 4; 
        monster.transform.position += move * delta4;
        if(Vector3.Distance(monster.transform.position , waypoint [3].transform.position)< 0.4f)
        {
        trig = 5;
		}
        break;
          case 5; 
        monster.transform.position += move * delta5;
        if(Vector3.Distance(monster.transform.position , waypoint [4].transform.position)< 0.4f)
        {
        trig = 6;
		}
        break;
          case 6; 
        monster.transform.position += move * delta6;
        if(Vector3.Distance(monster.transform.position , waypoint [5].transform.position)< 0.4f)
        {
        trig = 7;
		}
        break;
          case 7; 
        monster.transform.position += move * delta7;
        if(Vector3.Distance(monster.transform.position , waypoint [6].transform.position)< 0.4f)
        {
        trig = 8;
		}
        break;
          case 8; 
        monster.transform.position += move * delta8;
        if(Vector3.Distance(monster.transform.position , waypoint [7].transform.position)< 0.4f)
        {
        trig = 9;
		}
        break;
          case 9; 
        monster.transform.position += move * delta9;
        if(Vector3.Distance(monster.transform.position , waypoint [8].transform.position)< 0.4f)
        {
        trig = 10;
		}
        break;
          case 10; 
        monster.transform.position += move * delta10;
        if(Vector3.Distance(monster.transform.position , waypoint [9].transform.position)< 0.4f)
        {
        trig = 11;
		}
        break;
		}
    }
}
