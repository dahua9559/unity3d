using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PureMVC.Patterns.Proxy;

public class DataProxy :Proxy {

    public new const string NAME = "DataProxy";

    private MyData myData = null;

    private int sum = 0;
    public DataProxy() : base(NAME)
    {
        myData = new MyData();
    }

    public void AddLevel(int addNum)
    {
        this.sum += addNum;
        myData.Level(this.sum);

        this.SendNotification("Msg_AddLevel", this.sum);
    }
}
