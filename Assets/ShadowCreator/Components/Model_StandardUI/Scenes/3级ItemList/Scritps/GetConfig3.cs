﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using xx1;

public class GetConfig3 : MonoBehaviour {
    public ItemList baseList1;


    public BaseList baseList2;
    

    public BaseList baseList3;

    void Start() {
        List<TaskConfig> taskConfig1s = new List<TaskConfig>();
        TaskConfig taskConfig = new TaskConfig() { title = "T1", introduction = "introduction1" };
        taskConfig1s.Add(taskConfig);
        TaskConfig task2Config = new TaskConfig() { title = "T2", introduction = "introduction1" };
        taskConfig1s.Add(task2Config);
        TaskConfig task3Config = new TaskConfig() { title = "T3", introduction = "introduction1" };
        taskConfig1s.Add(task3Config);

        List<TaskConfig> taskConfig2s = new List<TaskConfig>();
        TaskConfig task4Config = new TaskConfig() { title = "T1", introduction = "introduction1" };
        taskConfig2s.Add(taskConfig);

        List<TaskConfig> taskConfig3s = new List<TaskConfig>();
        TaskConfig task5Config = new TaskConfig() { title = "T1", introduction = "introduction1" };
        taskConfig3s.Add(taskConfig);
        TaskConfig task6Config = new TaskConfig() { title = "T2", introduction = "introduction1" };
        taskConfig3s.Add(task2Config);



        List<ProjectConfig> baseList2Config = new List<ProjectConfig>();
        ProjectConfig bl2config1 = new ProjectConfig(baseList3, taskConfig1s.Cast<BaseConfig>().ToList()) {
            title = "P1",
            introduction = "introduction1"
        };
        baseList2Config.Add(bl2config1);
        ProjectConfig bl2config2 = new ProjectConfig(baseList3, taskConfig2s.Cast<BaseConfig>().ToList()) {
            title = "P2",
            introduction = "introduction1"
        };
        baseList2Config.Add(bl2config2);


        List<ProjectConfig> baseList2Config1 = new List<ProjectConfig>();
        ProjectConfig bl2config11 = new ProjectConfig(baseList3, taskConfig3s.Cast<BaseConfig>().ToList()) {
            title = "P1",
            introduction = "introduction1"
        };
        baseList2Config1.Add(bl2config11);


        List<ProjectConfig> baseList1Config = new List<ProjectConfig>();
        ProjectConfig bl1config1 = new ProjectConfig(baseList2, baseList2Config.Cast<BaseConfig>().ToList()) {
            title = "P1",
            introduction = "introduction1"
        };
        baseList1Config.Add(bl1config1);
        ProjectConfig bl1config2 = new ProjectConfig(baseList2, baseList2Config1.Cast<BaseConfig>().ToList()) {
            title = "P2",
            introduction = "introduction2"
        };
        baseList1Config.Add(bl1config2);

        baseList1.CurrentViewNum = 2;
        baseList1.UpdateConfigs(baseList1Config.Cast<BaseConfig>().ToList());
    }

}
