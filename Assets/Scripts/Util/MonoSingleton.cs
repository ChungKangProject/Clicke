using UnityEngine;

namespace Developers.Util
{
    public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        protected static T instance = null;
        protected static readonly Object sync_root = new Object ( );
        protected static bool app_is_close = false;
        public static bool IsAppClose { get => app_is_close; }

        public static T Instance
        {
            get
            {
                lock ( sync_root )
                {
                    if ( instance == null )
                    {
                        T[] instances = GameObject.FindObjectsOfType<T> ( );
                        if ( instances.Length == 1 )
                        {
                            instance = instances[0];
                        }
                        else if ( instances.Length > 1 )
                        {
                            Debug.LogWarning ( "Scene에 " + typeof ( T ).ToString ( ) + "가 추가적으로 있습니다." );
                            foreach ( var obj in instances )
                            {
                                Debug.LogWarning ( typeof ( T ).ToString ( ) + ":" + obj.gameObject.name );
                            }
                        }
                        if ( instance == null )
                        {
                            Debug.LogError ( "객체를 찾을 수 없습니다." );
#if UNITY_EDITOR
                            Debug.Break ( );
#endif
                        }
                    }
                    return instance;
                }
            }
            set
            {
                if ( instance != null )
                {
                    string message = string.Format ( "Scene에 이미 {0}가 있습니다.", typeof ( T ).ToString ( ) );
                    Debug.LogWarning ( message );
                    return;
                }
                else
                {
                    instance = value;
                }
            }
        }

        private void OnDestroy ( )
        {
#if ( !UNITY_EDITOR )
            if ( Instance == this ) { app_is_close = true; }
#endif
        }


        private void OnApplicationQuit ( )
        {
#if ( !UNITY_EDITOR )
            if ( Instance == this ) { _app_is_close = true; }
#endif
        }
    }
}