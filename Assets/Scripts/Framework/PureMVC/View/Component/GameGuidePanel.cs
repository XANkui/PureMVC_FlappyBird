/****************************************************
文件：GameGuidePanel.cs
建立者：Administrator
作者：仙魁XAN
邮箱：https://blog.csdn.net/u014361280 
日期：2020/08/18 16:51:10
主题：游戏操作说明UI
功能：Nothing
*****************************************************/

using PureMVC.Patterns;
using SUIFW;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PureMVC_FlappyBird
{
    public class GameGuidePanel : BaseUIForm
    {
        private void Awake()
        {
            // 设置窗体类型
            CurrentUIType.UIForms_ShowMode = UIFormShowMode.HideOther;

            // 注册按钮事件
            RegisterButtonObjectEvent("GameGuide_Image",p=>{

                    OpenUIForm(ConstData.GamePlayingPanel);

                    // PureMVC 发送命令  开始游戏
                    Facade.Instance.SendNotification(ConstData.Reg_StartGameCommand);
            });

            
        }
    }
}
