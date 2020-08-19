/****************************************************
文件：Ctrl_Pips.cs
建立者：Administrator
作者：仙魁XAN
邮箱：https://blog.csdn.net/u014361280 
日期：2020/08/19 09:38:45
主题：管道碰撞检测脚本
功能：Nothing
*****************************************************/

using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PureMVC_FlappyBird
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class Ctrl_PipsAndLanding : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            // 碰撞到玩家
            if (collision.gameObject.tag.Equals("Player"))
            {
                // 通知游戏结束
                Facade.Instance.SendNotification("Reg_EndGameCommand");
            }
            
        }
    }
}
