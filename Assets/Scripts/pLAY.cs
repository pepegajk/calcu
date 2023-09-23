using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pLAY : MonoBehaviour
{
    public string sceneName;
    public Button playButton;
    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(sceneName);
    }
}
