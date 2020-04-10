﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SC.InputSystem;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System;

public class BackKeyCallBackSet : PointerDelegate
{

    static BackKeyCallBackSet instant;
    public EventTrigger eventTrigger;
    public bool IsBackQuit = true;
    public Action BackKeyCallBack;

    void Awake() {
        if(instant) {
            DestroyImmediate(gameObject);
            return;
        }
        instant = this;
        DontDestroyOnLoad(gameObject);
    }

    protected override void partAnyKeyDownDelegate(InputKeyCode keyCode, InputDevicePartBase part) {
        base.partAnyKeyDownDelegate(keyCode, part);

        if(keyCode != InputKeyCode.Back)
            return;

        if(BackKeyCallBack != null) {
            BackKeyCallBack();
        }
    }

    void Update() {
        if(BackKeyCallBack != null) {
            Input.backButtonLeavesApp = false;
        } else {
            Input.backButtonLeavesApp = true;
        }
    }
}