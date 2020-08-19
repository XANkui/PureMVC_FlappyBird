/****************************************************
文件：Ctrl_Golds.cs
建立者：Administrator
作者：仙魁XAN
邮箱：https://blog.csdn.net/u014361280 
日期：2020/08/19 11:37:21
主题：控制层 中间管道的触发检测
功能：Nothing
*****************************************************/

using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PureMVC_FlappyBird
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class Ctrl_Golds : MonoBehaviour
    {
        // 模型代理
        public Model_GameDataProxy dataProxy = null;

        // 游戏是否开始
        private bool _isGameStart = false;

        /// <summary>
        /// 游戏开始
        /// </summary>
        public void StartGame()
        {
            _isGameStart = true;

            // 得到模型代理
            dataProxy = Facade.Instance.RetrieveProxy(Model_GameDataProxy.NAME) as Model_GameDataProxy;

        }

        /// <summary>
        /// 游戏结束
        /// </summary>
        public void StopGame()
        {
            _isGameStart = false;
        }

        // Start is called before the first frame update
        void Start()
        {
            // 设置为 Trigger 检测
            GetComponent<BoxCollider2D>().isTrigger = true;
        }

        /// <summary>
        /// 碰撞检测
        /// </summary>
        /// <param name="collision"></param>
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (_isGameStart == true)
            {
                if (collision.gameObject.tag.Equals("Player"))
                {
                    // 增加分数
                    if (dataProxy != null)
                    {
                        dataProxy.AddScores();
                    }
                }
            }
        }
    }
}
