﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{


    private int b;

    int test1ab = 10000;



     
    //1번 클릭할때마다 gold에 양 증가.
    public void OnClick()
    {
        int goldperClick = DataController.Instance.goldPerClick;
        DataController.Instance.gold += goldperClick;
    }
}
    