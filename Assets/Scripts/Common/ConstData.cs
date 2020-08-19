/****************************************************
文件：ConstData.cs
建立者：Administrator
作者：仙魁XAN
邮箱：https://blog.csdn.net/u014361280 
日期：2020/08/18 16:26:50
主题：FlappyBird项目所有常量
功能：Nothing
*****************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PureMVC_FlappyBird
{
    public class ConstData 
    {
        /* PureMVC 通信常量 */
        // 命令通知
        public const string Reg_StartGameCommand = "Reg_StartGameCommand";
        public const string Reg_EndGameCommand = "Reg_EndGameCommand";

        // 消息通知
        public const string Msg_DisplayGameDataInfo = "Msg_DisplayGameDataInfo";

        /* UI 窗体预设名称 */
        public const string StartGamePanel = "StartGamePanel";
        public const string GameGuidePanel = "GameGuidePanel";
        public const string GamePlayingPanel = "GamePlayingPanel";

        /* 其他常量 */
    }
}
