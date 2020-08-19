/****************************************************
文件：View_GamePlayingMediator.cs
建立者：Administrator
作者：仙魁XAN
邮箱：https://blog.csdn.net/u014361280 
日期：2020/08/18 21:57:59
主题：Nothing
功能：Nothing
*****************************************************/

using PureMVC.Interfaces;
using PureMVC.Patterns;
using SUIFW;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PureMVC_FlappyBird
{
    public class View_GamePlayingMediator : Mediator
    {
        public new const string NAME = "View_GamePlayingMediator";

        // UI 控件
        private Text TimeTitle_Text;
        private Text TimeDy_Text;
        private Text HighestScoreTitle_Text;
        private Text HighestScoreDy_Text;
        private Text CurrentScoreTitle_Text;
        private Text CurrentScoreDy_Text;

        public View_GamePlayingMediator() : base(NAME) {

            // 得到层级视图层根节点
            GameObject goRootCanvas = GameObject.Find("Canvas(Clone)");

            // 得到文本控件
            TimeTitle_Text = UnityHelper.GetTheChildNodeComponetScripts<Text>( goRootCanvas, "TimeTitle_Text");
            HighestScoreTitle_Text = UnityHelper.GetTheChildNodeComponetScripts<Text>( goRootCanvas, "HighestScoreTitle_Text");
            CurrentScoreTitle_Text = UnityHelper.GetTheChildNodeComponetScripts<Text>( goRootCanvas, "CurrentScoreTitle_Text");
            TimeTitle_Text.text = "时间";
            HighestScoreTitle_Text.text = "最高";
            CurrentScoreTitle_Text.text = "分数";

            // 得到文本显示控件
            TimeDy_Text = UnityHelper.GetTheChildNodeComponetScripts<Text>(goRootCanvas, "TimeDy_Text");
            HighestScoreDy_Text = UnityHelper.GetTheChildNodeComponetScripts<Text>(goRootCanvas, "HighestScoreDy_Text");
            CurrentScoreDy_Text = UnityHelper.GetTheChildNodeComponetScripts<Text>(goRootCanvas, "CurrentScoreDy_Text");
        }

        /// <summary>
        /// 允许接受的消息队列
        /// </summary>
        /// <returns></returns>
        public override IList<string> ListNotificationInterests()
        {
            IList<string> listResult = new List<string>();
            listResult.Add(ConstData.Msg_DisplayGameDataInfo);

            return listResult;
        }

        /// <summary>
        /// 处理接收到的消息
        /// </summary>
        /// <param name="notification"></param>
        public override void HandleNotification(INotification notification)
        {
            Model_GameData gameData = null;
            switch (notification.Name)
            {
                case ConstData.Msg_DisplayGameDataInfo:

                    gameData = notification.Body as Model_GameData;


                    if (gameData != null)
                    {
                        if (TimeDy_Text && HighestScoreDy_Text && CurrentScoreDy_Text)
                        {
                            TimeDy_Text.text = gameData.GameTime.ToString();
                            HighestScoreDy_Text.text = gameData.HighestScore.ToString();
                            CurrentScoreDy_Text.text = gameData.Scores.ToString();
                        }
                    }

                    break;

                default:
                    break;
            }
        }
    }
}
