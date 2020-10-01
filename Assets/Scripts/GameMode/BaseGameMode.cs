﻿using UnityEngine;
using System.Collections.Generic;
using UnityEngine.AddressableAssets;

public abstract class BaseGameMode : MonoBehaviour
{
    [SerializeField] 
    private AssetLabelReference assetLabelReference;

    protected List<BasePage> PagePool = new List<BasePage> ( );
    protected BasePage CurrentPage { get; set; }


    public void Load()
    {
        LoadManager.Instance.Register ( assetLabelReference );
        LoadManager.Instance.Run ( );
    }

    /// <summary>현재 게임모드의 UI 페이지에서 선택한 UI 페이지로 전환합니다.</summary>
    public BasePage SetPage(BasePage page)
    {
        if(CurrentPage == null || CurrentPage.Equals(page))
        {
            return CurrentPage;
        }
        CurrentPage = page;
        bool bEmpty = PagePool.Find ( _ => _.Equals ( page ) ) == null;
        if( bEmpty )
        {
            PagePool.Add ( page );
        }
        return page;
    }


    public virtual void OnEnter ( ) { }
    public virtual void OnUpdate ( ) { }
    public virtual void OnExit ( ) { }

    protected virtual void Update ( )
    {
        OnUpdate ( );
    }
}
