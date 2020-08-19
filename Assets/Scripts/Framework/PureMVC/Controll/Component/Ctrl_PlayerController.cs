/****************************************************
文件：Ctrl_PlayerController.cs
建立者：Administrator
作者：仙魁XAN
邮箱：https://blog.csdn.net/u014361280 
日期：2020/08/18 21:20:32
主题：小鸟运动控制脚本
功能：Nothing
*****************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PureMVC_FlappyBird
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Ctrl_PlayerController : MonoBehaviour
    {
        // 升力
        public float _floatUpPower = 3.0f;

        // 玩家 2D 刚体
        private Rigidbody2D _rd2D;

        // 主角原始位置
        private Vector2 _vecPlayerOriginalPosition;

        // 游戏是否开始
        private bool _isGameStart = false;

        /// <summary>
        /// 游戏开始
        /// </summary>
        public void StartGame() {
            _isGameStart = true;

            // 恢复原始位置
            this.transform.position = _vecPlayerOriginalPosition;

            // 启用 2D 刚体
            SetEnableRigibody2D(true);           
        }

        /// <summary>
        /// 游戏结束
        /// </summary>
        public void StopGame() {
            _isGameStart = false;

            // 恢复原始位置
            this.transform.position = _vecPlayerOriginalPosition;

            // 禁用 2D 刚体
            SetEnableRigibody2D(false);

            
        }

        // Start is called before the first frame update
        void Start()
        {
            // 保存原始位置
            _vecPlayerOriginalPosition = this.transform.position;

            // 获取 2D 刚体
            _rd2D = this.gameObject.GetComponent<Rigidbody2D>();

            // 禁用 2D 刚体
            SetEnableRigibody2D(false);

           
        }

        /// <summary>
        /// 接收玩家输入
        /// </summary>
        private void Update()
        {
            if (_isGameStart == true)
            {
                if (Input.GetButton("Fire1"))
                {
                    _rd2D.velocity = Vector2.up * _floatUpPower;
                }
            }    
        }

        /// <summary>
        /// 设置 2D 刚体属性
        /// </summary>
        private void SetEnableRigibody2D(bool isEnable) {
            this.gameObject.GetComponent<Rigidbody2D>().bodyType = isEnable ==false ? RigidbodyType2D.Kinematic: RigidbodyType2D.Dynamic;
        }
    }
}
