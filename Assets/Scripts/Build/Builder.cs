using System.Collections;
using UnityEngine;
using Developers.Structure;
using Developers.Util;

public class Builder : MonoBehaviour
{
    private SpriteRenderer spriteRenderer = null;
    public BuildingType buildingType;


    public bool Load()
    {
         GameObject building = GameManager.Create<Building> ( new ActorRecord ( ActorType.Building, (int)buildingType ) );

        if(building == null)
        {
            Debug.LogErrorFormat ( "{0} Type의 건물 생성에 실패하였습니다.", buildingType );
            return false;
        }

        Instantiate ( building, transform.position, Quaternion.identity );
        // FIXME 우선 여기에 작성을 했지만 Load자체를 다른 곳에서 해주고 true반환 시 삭제 false반환시 재시도 해줘야함.
        Destroy ( gameObject, 1f );

        return true;
    }


    private void Awake ( )
    {
        spriteRenderer = GetComponent<SpriteRenderer> ( );
        spriteRenderer.enabled = false;
    }

    private IEnumerator Start()
    {
        yield return new WaitUntil ( ( ) => MonoSingleton<GameManager>.Instance.IsGameStart );
        Load ( );
    }
}
