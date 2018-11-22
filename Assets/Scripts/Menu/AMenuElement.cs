using System;
using UnityEngine;

/**
 * Abstract menu item class providing show and hide methods.
 */
public abstract class AMenuElement: MonoBehaviour {

    private Vector3 _initialScale;

    private void Start() {
        this._initialScale = this.transform.localScale;
    }

    public void Hide() {
        this.transform.localScale = Vector3.zero;
    }

    public void Show() {
        this.transform.localScale = this._initialScale;
    }
}