/****************************************************
文件：Ctrl_EndGameCommand.cs
建立者：Administrator
作者：仙魁XAN
邮箱：https://blog.csdn.net/u014361280 
日期：2020/08/18 21:55:13
主题：命令层（控制层）GameOver
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
    public class Ctrl_EndGameCommand : SimpleCommand
    {
        public override void Execute(INotification notification)
        {
            // 停止脚本运行
            StopScriptsRunning();
            // 打开 界面猜操作UI
            OpenUIForm();

            // 保存最高分数
            (Facade.RetrieveProxy(Model_GameDataProxy.NAME) as Model_GameDataProxy).SaveHighestScore();
        }

        /// <summary>
        /// 停止脚本运行
        /// </summary>
        private void StopScriptsRunning() {
            // 停止游戏
            GameObject.FindGameObjectWithTag("Player").GetComponent<Ctrl_PlayerController>().StopGame();


            // 得到层级跟对象
            GameObject goEnvRoot = GameObject.Find("Env");

            // 管道也停止游戏
            UnityHelper.GetTheChildNodeComponetScripts<Ctrl_PipsMoving>(goEnvRoot, "GamePips").StopGame();

            // 给中间Trigger管道停止游戏
            for (int i = 1; i < 4; i++)
            {

                UnityHelper.GetTheChildNodeComponetScripts<Ctrl_Golds>(goEnvRoot, "Pip" + i + "_Trigger").StopGame();
            }

            // 计时脚本停止游戏
            goEnvRoot.GetComponent<Ctrl_GetTime>().StopGame();
        }

        /// <summary>
        /// 回到游戏操作界面
        /// </summary>
        private void OpenUIForm() {
            UIManager.GetInstance().CloseUIForms("GamePlayingPanel");
        }
    }
}
