using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {
    public GameObject optionPanel;
    public GameObject exitPanel;

    void Start () {
        optionPanel.SetActive(false);
        exitPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKeyDown(KeyCode.Escape) && exitPanel.activeInHierarchy == false))
        {
            if (optionPanel.activeInHierarchy == false)
            {
                optionPanel.SetActive(true);
            }
            else
            {
                optionPanel.SetActive(false);
            }
        }
	}
    public void ExitButton ()
    {
        optionPanel.SetActive(false);
        exitPanel.SetActive(true);
    }
    public void CancelExitButton ()
    {
        optionPanel.SetActive(true);
        exitPanel.SetActive(false);
    }
    public void ExitApplication()
    {
        Application.Quit();
    }
}
