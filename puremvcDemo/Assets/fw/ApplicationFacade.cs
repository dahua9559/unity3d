using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PureMVC.Patterns.Facade;

public class ApplicationFacade :Facade {

    /// <summary>
    /// 构造函数操作
    /// </summary>
	public ApplicationFacade(GameObject goRootNode)
    {
        RegisterCommand("Reg_StartDataCommand", () => { return new DataCommand(); });
        RegisterMediator(new DataMediator(goRootNode));
        RegisterProxy(new DataProxy());
    }
}
