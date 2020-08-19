/****************************************************
文件：Ctrl_GetTime.cs
建立者：Administrator
作者：仙魁XAN
邮箱：https://blog.csdn.net/u014361280 
日期：2020/08/19 11:09:48
主题：控制层 每一秒向模型代理层发送时间消息
功能：Nothing
*****************************************************/

using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PureMVC_FlappyBird
{
    public class Ctrl_GetTime : MonoBehaviour
    {
        // 模型代理
        public Model_GameDataProxy dataProxy = null;

        // 游戏是否开始
        private bool _isGameStart = false;

        /// <summary>
        /// 游戏开始
        /// </summary>
        public void StartGame() {
            _isGameStart = true;

            // 得到模型代理
            dataProxy = Facade.Instance.RetrieveProxy(Model_GameDataProxy.NAME) as Model_GameDataProxy;

        }

        /// <summary>
        /// 游戏结束
        /// </summary>
        public void StopGame() {
            _isGameStart = false;
        }


        private void Start()
        {
            StartCoroutine("GetTime");
        }

        IEnumerator GetTime() {
            yield return new WaitForEndOfFrame();

            while (true) {
                yield return new WaitForSeconds(1);

                if (dataProxy != null && _isGameStart == true)
                {
                    // 调用模型层像视图层（Mediator）发送消息
                    dataProxy.AddGameTime();
                }
            }
        }
    }


}
