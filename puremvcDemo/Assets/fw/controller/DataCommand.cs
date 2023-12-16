using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PureMVC.Interfaces;
using PureMVC.Patterns.Command;

public class DataCommand :SimpleCommand {

    public override void Execute(INotification notification)
    {
        DataProxy dataProxy = Facade.RetrieveProxy(DataProxy.NAME) as DataProxy;
        dataProxy.AddLevel(5);
    }
}
