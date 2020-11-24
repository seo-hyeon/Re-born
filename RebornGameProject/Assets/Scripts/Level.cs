﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public string LevelName
    {
        get
        {
            return name;
        }
    }
    
    [SerializeField]
    private Transform mLevelCamPos;
    public Transform LevelCamPos
    {
        get
        {
            return 
                mLevelCamPos;
        }
    }
    
    [SerializeField]
    private Level mNextLevel;
    public Level NextLevel
    {
        get
        {
            return mNextLevel;
        }
    }
    
    // 다음 단계로 카메라 이동
    // 레이어 마스크 이용해 안보이게 했다가 보이도록 하는 방식 고려
    public void MoveNextLevel()
    {
        Camera.main.GetComponent<CamMoveNextLevel>().MovePos(LevelCamPos);
    }
}
