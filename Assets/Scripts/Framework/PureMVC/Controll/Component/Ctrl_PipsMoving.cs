/****************************************************
文件：Ctrl_PipsMoving.cs
建立者：Administrator
作者：仙魁XAN
邮箱：https://blog.csdn.net/u014361280 
日期：2020/08/19 09:06:53
主题：控制层 管道移动脚本
功能：Nothing
*****************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ctrl_PipsMoving : MonoBehaviour
{
    // 移动速度
    public float _floatMovingSpeed = 1.0f;

    // 初始位置
    private Vector2 _vector2OriginalPosition;

    // 游戏是否开始
    private bool _isGameStart = false;

    /// <summary>
    /// 游戏开始
    /// </summary>
    public void StartGame()
    {
        _isGameStart = true;

        
    }

    /// <summary>
    /// 游戏结束
    /// </summary>
    public void StopGame()
    {
        _isGameStart = false;

        // 恢复原始位置
        this.transform.position = _vector2OriginalPosition;

  
    }


    // Start is called before the first frame update
    void Start()
    {
        // 记录初始位置
        _vector2OriginalPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (_isGameStart == true)
        {
            // 循环移动，到了 “临界位置”，回到初始位置
            if (this.transform.position.x < -19.5f)
            {
                this.transform.position = _vector2OriginalPosition;
            }

            // 移动
            this.transform.Translate(Vector2.left * Time.deltaTime * _floatMovingSpeed);
        }
        
    }
}
