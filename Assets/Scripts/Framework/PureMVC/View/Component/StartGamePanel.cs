/****************************************************
文件：StartGamePanel.cs
建立者：Administrator
作者：仙魁XAN
邮箱：https://blog.csdn.net/u014361280 
日期：2020/08/18 16:48:46
主题：游戏开始界面
功能：Nothing
*****************************************************/

using SUIFW;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PureMVC_FlappyBird
{
    public class StartGamePanel : BaseUIForm
    {

        private void Awake()
        {
            // 注册按钮事件
            RegisterButtonObjectEvent("Start_Image", p=>OpenUIForm(ConstData.GameGuidePanel));
        }

        // Start is called before the first frame update
        void Start()
        {
            // 启动 Pure MVC
            new ApplicationFacade();
        }

       
    }
}
