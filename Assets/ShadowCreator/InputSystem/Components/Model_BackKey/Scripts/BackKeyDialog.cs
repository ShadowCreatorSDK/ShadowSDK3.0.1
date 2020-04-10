﻿using SC.InputSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackKeyDialog : PointerDelegate
{
    public BackKeyDialogUI UI;
    static BackKeyDialog instant;
    void Awake() {
        if(instant) {
            DestroyImmediate(gameObject);
            return;
        }
        instant = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start() {
        Input.backButtonLeavesApp = false;
        SceneManager.activeSceneChanged += ChangedActiveScene;
    }
    void OnDestroy() {
        SceneManager.activeSceneChanged -= ChangedActiveScene;
    }

    protected override void partAnyKeyDownDelegate(InputKeyCode keyCode, InputDevicePartBase part) {
        base.partAnyKeyDownDelegate(keyCode, part);

        if(keyCode != InputKeyCode.Back)
            return;

        if(Input.backButtonLeavesApp == true)
            return;
        if(!UI)
            return;
        if(UI.gameObject.activeSelf == true) {
            Application.Quit();
        } else {
            UI.gameObject.SetActive(true);
        }
    }
    void Update() {
#if UNITY_EDITOR
        if(Input.GetKeyDown(KeyCode.Escape)) {
            partAnyKeyDownDelegate(InputKeyCode.Back, null);
        }
#endif
    }

    private void ChangedActiveScene( Scene current, Scene next ) {
        Input.backButtonLeavesApp = false;
    }
}