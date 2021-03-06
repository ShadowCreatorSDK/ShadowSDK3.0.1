﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class PermissionRequest : MonoBehaviour
{
    string[] permissionList ={
            Permission.ExternalStorageRead,
            Permission.ExternalStorageWrite,
            Permission.Camera
        };

    void Awake() {
        if(permissionList.Length > 0) {
            AndroidPluginPermission.getInstant.RequestPermission(permissionList);
        }
    }



}
