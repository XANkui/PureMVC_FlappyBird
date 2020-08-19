/****************************************************
文件：Model_GameDataProxy.cs
建立者：Administrator
作者：仙魁XAN
邮箱：https://blog.csdn.net/u014361280 
日期：2020/08/18 21:56:48
主题：模型层 游戏数据实体类代理
功能：Nothing
*****************************************************/

using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PureMVC_FlappyBird
{
    public class Model_GameDataProxy : Proxy
    {
        // 类名称，方便框架查询该类
        public new const string NAME = "Model_GameDataProxy";

        private Model_GameData _GameData;

        public Model_GameDataProxy() : base(NAME) {

            _GameData = new Model_GameData();

            // 得到最高分
            _GameData.HighestScore = GetHighestScore();
        }

        /// <summary>
        /// 增加时间
        /// </summary>
        public void AddGameTime() {
            ++_GameData.GameTime;

            // 数值发送给视图层
            SendNotification(ConstData.Msg_DisplayGameDataInfo, _GameData);
        }

        /// <summary>
        /// 增加分数
        /// </summary>
        public void AddScores() {
            ++_GameData.Scores;

            // 更新最高分数
            if (_GameData.Scores>_GameData.HighestScore)
            {
                _GameData.HighestScore = _GameData.Scores;
            }

            // 数值发送给视图层(这里可不要，因为时间会每秒更新，这里也就被动更新了)
            //SendNotification("Msg_DisplayGameDataInfo", _GameData);
        }


        /// <summary>
        /// 得到最高分
        /// </summary>
        /// <returns></returns>
        public int GetHighestScore() {
            return PlayerPrefs.GetInt("HighestScore",0);
        }

        /// <summary>
        /// 保存最高分
        /// </summary>        
        public void SaveHighestScore()
        {
            if (_GameData.Scores > GetHighestScore())
            {
                PlayerPrefs.SetInt("HighestScore", _GameData.Scores);

                PlayerPrefs.Save();       //意外退出游戏，不 Save ，可能不会自动保存，请注意
            }
            
        }


    }
}
