/****************************************************
文件：Ctrl_StartGameCommand.cs
建立者：Administrator
作者：仙魁XAN
邮箱：https://blog.csdn.net/u014361280 
日期：2020/08/18 21:54:21
主题：命令层（控制层）
功能：
    1、注册模型与视图层
    2、注册重新开始
*****************************************************/

using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PureMVC_FlappyBird
{
    public class Ctrl_StartGameCommand : MacroCommand
    {
        protected override void InitializeMacroCommand()
        {
            Debug.Log(GetType()+ "/InitializeMacroCommand()/");

            // 注册模型于视图Command
            AddSubCommand(typeof(Ctrl_RegisterModelAndViewCommand));

            // 注册重新开始游戏 Command
            AddSubCommand(typeof(Ctrl_RestartGameCommand));
        }
    }
}
