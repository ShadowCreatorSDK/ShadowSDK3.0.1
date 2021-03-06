﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ShadowKit.Action.Vuforia
{
	public class VuforiaLocation : MonoBehaviour {
        public float RGBPositionOffsetX = 0f;
        public float RGBPositionOffsetY = 0.07f;
        public float RGBPositionOffsetZ = -0.03f;

        public float RGBRotationOffsetX = -8f;
        public float RGBRotationOffsetY = 0;
        public float RGBRotationOffsetZ = 0;
        // Use this for initialization
        void Start () {
            StartCoroutine(InitARCamera());
		}

        IEnumerator InitARCamera() {
            while (true) {
                if (SvrManager.Instance.IsRunning) {
                    transform.SetParent(SvrManager.Instance.head,false);
                    transform.localPosition = new Vector3(RGBPositionOffsetX, RGBPositionOffsetY, RGBPositionOffsetZ);
                    transform.localEulerAngles = new Vector3(RGBRotationOffsetX, RGBRotationOffsetY, RGBRotationOffsetZ);
                    yield break;
                }
                yield return null;
            }
        }
		// Update is called once per frame
		void Update () {
			//gameObject.transform.position = SvrManager.Instance.modifyPosition;
			//gameObject.transform.rotation = SvrManager.Instance.modifyOrientation;
		}
	}
}
