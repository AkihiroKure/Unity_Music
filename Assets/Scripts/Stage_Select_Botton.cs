using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage_Select_Botton : MonoBehaviour
{
    public string note;
    public GameObject SelectSceneManager;// getter
   
    // Use this for initialization
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            SelectSceneManager.GetComponent<StageSceneManager>().setnote(note);
            SceneManager.LoadScene("PlayScene");
        }
    }
}
