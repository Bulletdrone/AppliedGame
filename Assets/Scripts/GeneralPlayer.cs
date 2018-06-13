using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralPlayer : MonoBehaviour {
    public GameObject OptionPanel;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (OptionPanel.activeInHierarchy == false)
            {
                OptionPanel.SetActive(true);
            }
            else
            {
                OptionPanel.SetActive(false);
            }
        }
	}
}
