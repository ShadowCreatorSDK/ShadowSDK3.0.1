﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace xx1 {
    public class StanderTaskConfig : TaskBaseConfig {

        public int num;

        public override void OnClick() {
            base.OnClick();
            Debug.Log("StanderTaskConfig :" + num + " OnClick");
        }
    }
}
