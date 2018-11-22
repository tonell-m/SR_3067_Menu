using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Menu : MonoBehaviour {

    private MenuItem[] menuItems;

	// Use this for initialization
	private void Start () {
        this.menuItems = this.GetComponentsInChildren<MenuItem>();

        for (int i = 0; i < this.menuItems.Length; i++) {
            this.menuItems[i].revealDelay = i * 0.4f;
        }
	}
	
	// Update is called once per frame
	private void Update () {
		
	}
}
