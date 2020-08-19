/****************************************************
文件：ApplicationFacade.cs
建立者：Administrator
作者：仙魁XAN
邮箱：https://blog.csdn.net/u014361280 
日期：2020/08/18 16:24:41
主题：PureMVC 各个模块层统一注册管理类
功能：Nothing
*****************************************************/

using PureMVC.Patterns;
using SUIFW;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PureMVC_FlappyBird
{
    public class ApplicationFacade : Facade
    {
        public ApplicationFacade() {

            // 添加游戏对象脚本
            AddGameObjectScript();

            // 注册核心的“命令”
            RegisterCommand(ConstData.Reg_StartGameCommand, typeof(Ctrl_StartGameCommand));
            RegisterCommand(ConstData.Reg_EndGameCommand, typeof(Ctrl_EndGameCommand));
                      
        }

        /// <summary>
        /// 添加游戏对象脚本
        /// </summary>
        private void AddGameObjectScript()
        {
            // 得到层级跟对象
            GameObject goEnvRoot = GameObject.Find("Env");

            // 添加主角控制脚本
            GameObject.FindGameObjectWithTag("Player").AddComponent<Ctrl_PlayerController>();

            // 添加地面移动脚本给地面
            UnityHelper.AddChildNodeCompnent<Ctrl_LandMoving>(goEnvRoot, "GameLanding");

            // 添加管道移动脚本给管道
            UnityHelper.AddChildNodeCompnent<Ctrl_PipsMoving>(goEnvRoot, "GamePips");

            // 给管道和地面添加碰撞脚本
            for (int i = 1; i < 4; i++)
            {
                
                    UnityHelper.AddChildNodeCompnent<Ctrl_PipsAndLanding>(goEnvRoot, "Pip"+i+"_Up");
                    UnityHelper.AddChildNodeCompnent<Ctrl_PipsAndLanding>(goEnvRoot, "Pip"+i+"_Down");
                    UnityHelper.AddChildNodeCompnent<Ctrl_PipsAndLanding>(goEnvRoot, "Landing" + i);
            }

            // 给中间Trigger管道添加碰撞脚本
            for (int i = 1; i < 4; i++)
            {

                UnityHelper.AddChildNodeCompnent<Ctrl_Golds>(goEnvRoot, "Pip" + i + "_Trigger");
            }

            // 添加时间脚本
            goEnvRoot.AddComponent<Ctrl_GetTime>();
        }
    }
}
