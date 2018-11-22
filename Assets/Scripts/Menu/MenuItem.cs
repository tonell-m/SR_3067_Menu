using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuItem : AMenuElement {

    [TextArea(3, 10)]
    public string textContent = "";

    public GameObject selectionIndicatorObject;
    private MenuSelector _selectionIndicator;

    protected TMP_Text text;

    public float revealDelay = 0f;
    public float revealCooldown = 0.4f;
    public int revealSpeed = 2;

    private int _revealCounter = 0;
    private float _revealTimer = 0f;
    private bool _startRevealing = false;


	void Start () {
        this._selectionIndicator = this.selectionIndicatorObject.GetComponent<MenuSelector>();
        this._selectionIndicator.Hide();
        this.text = this.GetComponent<TMP_Text>();
        this.text.text = this.textContent;
        this.text.maxVisibleCharacters = 0;
	}


	void Update () {

        this._revealTimer += Time.deltaTime;

        if (this._revealTimer >= this.revealDelay && !this._startRevealing) {
            this._revealTimer = 0f;
            this._startRevealing = true;
        }

        if (this._revealTimer >= this.revealCooldown && this._startRevealing) {
            this.text.maxVisibleCharacters = this._revealCounter;
            this._revealCounter += this.revealSpeed;
            this._revealTimer = 0f;
        }

        if (Input.anyKeyDown) {
            this.revealSpeed = 10;
            this.revealCooldown = 0;
        }

        if (this._revealCounter > this.textContent.Length) {
            this._selectionIndicator.Show();
        }
    }
}
