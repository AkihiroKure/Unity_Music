using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSceneManager : MonoBehaviour {
    public static string note;
    // getter
    public static string getnote()
    {
        return note;
    }
    public void setnote(string str)
    {
        
        note = str;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
