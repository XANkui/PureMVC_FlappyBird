/****************************************************
文件：Ctrl_LandMoving.cs
建立者：Administrator
作者：仙魁XAN
邮箱：https://blog.csdn.net/u014361280 
日期：2020/08/18 22:34:59
主题：控制层 地面移动脚本
功能：Nothing
*****************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PureMVC_FlappyBird
{
    public class Ctrl_LandMoving : MonoBehaviour
    {
        // 移动速度
        public float _floatMovingSpeed = 1.0f;

        // 初始位置
        private Vector2 _vector2OriginalPosition;

        // Start is called before the first frame update
        void Start()
        {
            // 记录初始位置
            _vector2OriginalPosition = this.transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            // 地面训话年移动，到了 “临界位置”，回到初始位置
            if (this.transform.position.x < -3.5f)
            {
                this.transform.position = _vector2OriginalPosition;
            }

            // 地面移动
            this.transform.Translate(Vector2.left * Time.deltaTime * _floatMovingSpeed);
        }
    }
}
