using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuSelector : AMenuElement {

    [SerializeField]
    private TMP_Text _tmproText;
    private int _currentIndex = 0;

    private MenuItem[] _items;

	// Use this for initialization
	void Start () {
        this._tmproText = this.GetComponent<TMP_Text>();
        print("tmproText: " + this._tmproText);

        this._tmproText.text = "X" + new string('\n', this._items.Length - 1);

        this._tmproText.maxVisibleCharacters = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow)) && this._currentIndex < this._items.Length - 1) {
            this._currentIndex++;
            this._tmproText.text = StringUtil.SwapCharacters(this._tmproText.text, this._currentIndex, this._currentIndex + 1);
        } else if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow)) && this._currentIndex > 0) {
            this._currentIndex--;
            this._tmproText.text = StringUtil.SwapCharacters(this._tmproText.text, this._currentIndex, this._currentIndex - 1);
        } else if (Input.GetKeyDown(KeyCode.Return)) {

        }
    }
}
