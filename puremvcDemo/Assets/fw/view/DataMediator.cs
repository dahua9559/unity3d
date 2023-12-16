using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using PureMVC.Interfaces;
using PureMVC.Patterns.Mediator;

public class DataMediator :Mediator
{
    public new const string NAME = "DataMediator";

    private Text Level_Text;

    private Button AddLevel_Button;

    public DataMediator(GameObject gameObject) : base(NAME)
    {
        this.Level_Text = gameObject.transform.Find("Level_Text").GetComponent<Text>();
        this.AddLevel_Button = gameObject.transform.Find("AddLevel_Button").GetComponent<Button>();

        this.AddLevel_Button.onClick.AddListener(onClick);
    }

    //事件
    private void onClick()
    {
        Debug.Log("点击了按钮");
        this.SendNotification("Reg_StartDataCommand");
    }

    //接受事件
    public override string[] ListNotificationInterests()
    {
        List<string> listResult = new List<string>();
        listResult.Add("Msg_AddLevel");
        return listResult.ToArray();
    }

    //事件执行
    public override void HandleNotification(INotification notification)
    {
        switch (notification.Name)
        {
            case "Msg_AddLevel":
                this.Level_Text.text = notification.Body.ToString();
                break;
            default:
                break;
        }
    }
}
