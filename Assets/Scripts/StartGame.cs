/****************************************************
文件：StartGame.cs
建立者：Administrator
作者：仙魁XAN
邮箱：https://blog.csdn.net/u014361280 
日期：2020/08/18 16:26:20
主题：游戏启动类
功能：负责游戏启动
*****************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SUIFW;

namespace PureMVC_FlappyBird
{
    public class StartGame : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            UIManager.GetInstance().ShowUIForms(ConstData.StartGamePanel);
        }

        
    }
}
