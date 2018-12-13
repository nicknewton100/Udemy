using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {
    //allows this to be availible inspector
    [SerializeField] Text textComponent;

	// Use this for initialization
	void Start ()
    {
        textComponent.text = ("hi") ;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
