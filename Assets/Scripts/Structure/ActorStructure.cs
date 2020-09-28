﻿using System;

namespace Developers.Structure
{
    ///<summary>액터의 종류</summary>
    public enum ActorType
    {
        None = 0,           // ERROR
        Character,          // 캐릭터
        Building,           // 건물
    }

    ///<summary>가져올 액터의 자료</summary>
    [Serializable]
    public struct ActorRecord
    {
        public ActorType type;
        public int key;
        public ActorRecord ( ActorType actorType, int recordKey ) => (type, key) = (actorType, recordKey);
    }

    // /************* 캐릭터 정보 *************/

    [Serializable]
    public class CharacterInfo
    { 
    }
    

    // /************* 건물 정보 *************/
    
    public enum BuildingType
    {
        None = 0,
        SpearmanTrainingCenter,            // 창병 훈련소
        WarriorTrainingCenter,             // 전사 훈련소
        Max,
    }

    [Serializable]
    public class BuildingInfo
    {
        public BuildingType buildingType;
    }
}