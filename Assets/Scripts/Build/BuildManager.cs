using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    //SingleTon
    public static BuildManager Instance;

    private void Awake()
    {
        if(Instance != null)
        {
            Debug.LogError("빌드를 2개이상 가질 수 없습니다.");
        }

        Instance = this;    
    }

    public GameObject WarriorBuild;
    public GameObject SpereBuild;

    
}
