/****************************************************
文件：Ctrl_RegisterModelAndViewCommand.cs
建立者：Administrator
作者：仙魁XAN
邮箱：https://blog.csdn.net/u014361280 
日期：2020/08/18 21:55:59
主题：命令层（控制层）注册模型与视图层
功能：Nothing
*****************************************************/

using PureMVC.Interfaces;
using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PureMVC_FlappyBird
{
    public class Ctrl_RegisterModelAndViewCommand : SimpleCommand
    {
        public override void Execute(INotification notification)
        {
            Facade.RegisterProxy(new Model_GameDataProxy());
            Facade.RegisterMediator(new View_GamePlayingMediator());
        }
    }
}
