using UnityEngine;

public class MainLobbyGameMode : BaseGameMode
{
    [SerializeField]
    private MainLobbyPage mainLobbyPage = null;


    public override void OnEnter ( )
    {
        SetPage ( mainLobbyPage );
    }

    public override void OnUpdate ( )
    {
        



    }

    public override void OnExit ( )
    {
        

    }
}

