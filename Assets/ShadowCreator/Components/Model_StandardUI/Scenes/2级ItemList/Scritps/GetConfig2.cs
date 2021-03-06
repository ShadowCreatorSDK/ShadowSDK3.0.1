﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using xx1;

public class GetConfig2 : MonoBehaviour {
    public ItemList itemList1,itemList2;

    public List<StanderProjectConfig> projectConfigs = new List<StanderProjectConfig>();

    public List<StanderTaskConfig> taskConfigs1 = new List<StanderTaskConfig>();
    public List<StanderTaskConfig> taskConfigs2 = new List<StanderTaskConfig>();
    public List<StanderTaskConfig> taskConfigs3 = new List<StanderTaskConfig>();
    public List<StanderTaskConfig> taskConfigs4 = new List<StanderTaskConfig>();

    void Start() {
        StanderTaskConfig standerTask1Config = new StanderTaskConfig() { title = "P1task1", introduction = "task1描述", num = 0 };
        StanderTaskConfig standerTask2Config = new StanderTaskConfig() { title = "P1task2", introduction = "task2描述", num = 1 };
        StanderTaskConfig standerTask3Config = new StanderTaskConfig() { title = "P1task3", introduction = "task3描述", num = 2 };
        StanderTaskConfig standerTask4Config = new StanderTaskConfig() { title = "P1task4", introduction = "task4描述", num = 3 };
        StanderTaskConfig standerTask5Config = new StanderTaskConfig() { title = "P1task5", introduction = "task5描述", num = 4 };
        StanderTaskConfig standerTask6Config = new StanderTaskConfig() { title = "P1task6", introduction = "task6描述", num = 5 };
        StanderTaskConfig standerTask7Config = new StanderTaskConfig() { title = "P1task7", introduction = "task7描述", num = 6 };
        StanderTaskConfig standerTask8Config = new StanderTaskConfig() { title = "P1task8", introduction = "task8描述", num = 7 };
        taskConfigs1.Add(standerTask1Config);
        taskConfigs1.Add(standerTask2Config);
        taskConfigs1.Add(standerTask3Config);
        taskConfigs1.Add(standerTask4Config);
        taskConfigs1.Add(standerTask5Config);
        taskConfigs1.Add(standerTask6Config);
        taskConfigs1.Add(standerTask7Config);
        taskConfigs1.Add(standerTask8Config);


        StanderTaskConfig standerTask21Config = new StanderTaskConfig() { title = "P2task1", introduction = "task1描述", num = 0 };
        StanderTaskConfig standerTask22Config = new StanderTaskConfig() { title = "P2task2", introduction = "task2描述", num = 1 };
        taskConfigs2.Add(standerTask21Config);
        taskConfigs2.Add(standerTask22Config);


        StanderTaskConfig standerTask31Config = new StanderTaskConfig() { title = "P3task1", introduction = "task1描述", num = 0 };
        taskConfigs3.Add(standerTask31Config);


        StanderTaskConfig standerTask41Config = new StanderTaskConfig() { title = "P4task1", introduction = "task1描述", num = 0 };
        StanderTaskConfig standerTask42Config = new StanderTaskConfig() { title = "P4task2", introduction = "task2描述", num = 1 };
        StanderTaskConfig standerTask43Config = new StanderTaskConfig() { title = "P4task3", introduction = "task3描述", num = 2 };
        taskConfigs4.Add(standerTask41Config);
        taskConfigs4.Add(standerTask42Config);
        taskConfigs4.Add(standerTask43Config);


        StanderProjectConfig projectConfig = new StanderProjectConfig(itemList2, taskConfigs1.Cast<BaseConfig>().ToList()) {
            title = "P1"
        };
        StanderProjectConfig projectConfig1 = new StanderProjectConfig(itemList2, taskConfigs2.Cast<BaseConfig>().ToList()) {
            title = "P2"
        };
        StanderProjectConfig projectConfig2 = new StanderProjectConfig(itemList2, taskConfigs3.Cast<BaseConfig>().ToList()) {
            title = "P3"
        };
        StanderProjectConfig projectConfig3 = new StanderProjectConfig(itemList2, taskConfigs4.Cast<BaseConfig>().ToList()) {
            title = "P4"
        };
        projectConfigs.Add(projectConfig);
        projectConfigs.Add(projectConfig1);
        projectConfigs.Add(projectConfig2);
        projectConfigs.Add(projectConfig3);


        itemList1.SetTitle("StanderItemList");
        itemList1.UpdateConfigs(projectConfigs.Cast<BaseConfig>().ToList());
    }

}
