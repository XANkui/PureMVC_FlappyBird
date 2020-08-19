/****************************************************
文件：Model_GameData.cs
建立者：Administrator
作者：仙魁XAN
邮箱：https://blog.csdn.net/u014361280 
日期：2020/08/18 21:56:29
主题：模型层 游戏数据实体类
功能：Nothing
*****************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PureMVC_FlappyBird
{
    public class Model_GameData 
    {
        // 游戏时间
        public int GameTime { get; set; }

        // 游戏分数
        public int Scores { get; set; }

        // 游戏最高分
        public int HighestScore { get; set; }
    }
}
