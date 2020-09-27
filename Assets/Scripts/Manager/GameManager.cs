using UnityEngine;
using Developers.Util;
using Developers.Structure;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoSingleton<GameManager>
{
    #region 기본 오브젝트
    public Camera MainCamera { get; private set; }
    #endregion


    private BaseGameMode gameMode;
    


    public BaseGameMode GameMode 
    {   
        get => gameMode; 
        set
        {
            gameMode?.OnExit ( );
            gameMode = value;
            gameMode?.OnEnter ( );
        }
    }


    
    public static GameObject Create( ActorRecord actorRecord )
    {
        GameObject gameObject = MonoSingleton<LoadManager>.Instance.Get ( actorRecord );
        return gameObject;
    }

    public static T Create<T>(ActorRecord actorRecord) where T : IActor
    {
        GameObject gameObject = MonoSingleton<LoadManager>.Instance.Get ( actorRecord );
        if(gameObject == null)
        {
            return default;
        }
        T component = gameObject.GetComponent<T> ( );
        return component;
    }


    private void Awake ( )
    {
        #region 기본 오브젝트 초기화
        MainCamera = Camera.main;
        #endregion

        // TODO : 우선 다른 씬이 없으므로 대체
        GameMode = GameObject.FindGameObjectWithTag ( "GameMode" ).GetComponent<BaseGameMode> ( );
    }
}