/****************************************************
文件：GamePlayingPanel.cs
建立者：Administrator
作者：仙魁XAN
邮箱：https://blog.csdn.net/u014361280 
日期：2020/08/18 17:01:56
主题：游戏游玩界面
功能：Nothing
*****************************************************/

using SUIFW;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PureMVC_FlappyBird
{
    public class GamePlayingPanel : BaseUIForm
    {
        private void Awake()
        {
            // 设置窗体类型
            CurrentUIType.UIForms_ShowMode = UIFormShowMode.HideOther;
        }
        // Start is called before the first frame update
        void Start()
        {

        }

       
    }
}
