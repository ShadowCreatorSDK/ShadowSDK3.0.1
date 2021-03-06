﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SC.Common
{
	public class ButtonMenu : Editor {


		[MenuItem("GameObject/ShadowSystem/SCButton")]
		public static void CreateSCButton()
		{
			GameObject added = GameObject.Find ("SCButton");
			GameObject obj;
			GameObject sel;
			if (added != null) {
				DestroyImmediate (added);
			}
			obj = (GameObject)Resources.Load ("Prefabs/SCButton");
			sel = (GameObject)Instantiate (obj);
			sel.name = "SCButton";

		}

        [MenuItem("GameObject/ShadowSystem/UIButton")]
        public static void CreateUIButton() {
            GameObject added = GameObject.Find("UIButton");
            GameObject obj;
            GameObject sel;
            if(added != null) {
                DestroyImmediate(added);
            }
            obj = (GameObject)Resources.Load("Prefabs/UIButton");
            sel = (GameObject)Instantiate(obj);
            sel.name = "UIButton";

        }
    }
}
