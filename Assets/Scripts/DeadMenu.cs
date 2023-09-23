using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManegment;

public class DeadMenu : MonoBehaviour
{
    public string ReplayScnene;
    public string MainmenuScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        public void Return()
        {
          SceneManegment.LoadScene(MainmenuScene);
		}
          
        public void Mainmenu()
        {
        SceneManegment.LoadScene(MainmenuScene);
		}
          
        public void Tilt()
        {
        
		}















    }
}
