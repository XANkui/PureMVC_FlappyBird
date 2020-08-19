/****************************************************
文件：Ctrl_RestartGameCommand.cs
建立者：Administrator
作者：仙魁XAN
邮箱：https://blog.csdn.net/u014361280 
日期：2020/08/18 21:55:32
主题：命令层（控制层） 重新运行
功能：Nothing
*****************************************************/

using PureMVC.Interfaces;
using PureMVC.Patterns;
using SUIFW;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PureMVC_FlappyBird
{
    public class Ctrl_RestartGameCommand : SimpleCommand
    {
        public override void Execute(INotification notification)
        {
            Debug.Log(GetType() + "/Execute()/");

            // 开始游戏
            GameObject.FindGameObjectWithTag("Player").GetComponent<Ctrl_PlayerController>().StartGame();

            // 得到层级跟对象
            GameObject goEnvRoot = GameObject.Find("Env");

            // 管道也开始游戏
            UnityHelper.GetTheChildNodeComponetScripts<Ctrl_PipsMoving>(goEnvRoot, "GamePips").StartGame();

            // 给中间Trigger管道开始游戏
            for (int i = 1; i < 4; i++)
            {

                UnityHelper.GetTheChildNodeComponetScripts<Ctrl_Golds>(goEnvRoot, "Pip" + i + "_Trigger").StartGame();
            }

            // 计时脚本开始游戏
            goEnvRoot.GetComponent<Ctrl_GetTime>().StartGame();
        }
    }
}
