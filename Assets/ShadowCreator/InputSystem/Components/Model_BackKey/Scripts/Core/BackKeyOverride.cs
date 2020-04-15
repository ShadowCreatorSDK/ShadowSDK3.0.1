using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SC.InputSystem;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System;

public class BackKeyOverride : PointerDelegate
{
    static BackKeyOverride Instant;
    event Action BackKeyCallBack;

    void Awake() {
        if(Instant) {
            DestroyImmediate(gameObject);
            return;
        }
        Instant = this;
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

    public static void AddBackKeyCallBack(Action BackKeyCallBack) {
        if(Instant) {
            Instant.BackKeyCallBack += BackKeyCallBack;
        } else {
            Debug.Log("Error:Please Put BackKeyOverride Scritps to a GameObject");
        }
    }
    public static void RemoveBackKeyCallBack(Action BackKeyCallBack) {
        if(Instant) {
            Instant.BackKeyCallBack -= BackKeyCallBack;
        }
    }

    void Update() {
        if(BackKeyCallBack != null) {
            Input.backButtonLeavesApp = false;
        } else {
            Input.backButtonLeavesApp = true;
        }

#if UNITY_EDITOR
        if(Input.GetKeyDown(KeyCode.Escape)) {
            partAnyKeyDownDelegate(InputKeyCode.Back, null);
        }
#endif

    }
}
