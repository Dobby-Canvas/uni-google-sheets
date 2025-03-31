#if UNITY_2017_1_OR_NEWER || UNITY_BUILD
using UnityEngine;
namespace UGS
{
    public static class UGSettingObjectWrapper
    {
        private const string Message = "UGSettingObject.asset 파일을 찾을 수 없습니다. 메뉴 가이드를 따라 세팅파일을 작성해주세요. <color=#00ff00><b>HamsterLib -> UGS -> UGSetting</b></color>";

        public static string GoogleFolderID
        {
            private static string _googleFolderId;
            private static string _scriptURL;
            private static string _scriptPassword;
            private static string _generateCodePath = "Assets/UGS.Generated/Scripts/";
            private static string _jsonDataPath = "Assets/UGS.Generated/Resources/";
            private static string _runtimeDataPath = "UGS/UGS.Data/";

            get
            {
#if UGS_SECURITY_MODE
                return null;
#else
            if (_googleFolderId == null)
                {
                    throw new System.Exception(Message);
                }
                return _googleFolderId;
#endif

            }
            set
            {
#if !UGS_SECURITY_MODE
                var setting = new UGSettingObject();

                var _googleFolderId = System.Environment.GetEnvironmentVariable("UGS_GOOGLE_FOLDER_ID");
                if (setting == null)
                {
                    throw new System.Exception(Message);
                }
                setting.GoogleFolderID = value;
                _googleFolderId = value;
#endif
#if UNITY_EDITOR && !UGS_SECURITY_MODE
                UnityEditor.EditorUtility.SetDirty(setting);
#endif
            }
        }
        public static string ScriptURL
        {
            get
            {
#if !UGS_SECURITY_MODE
                var _scriptURL = System.Environment.GetEnvironmentVariable("UGS_SCRIPT_URL");
                if (_scriptURL == null)
                {
                    throw new System.Exception(Message);
                }
                return _scriptURL;
#endif
#pragma warning disable 162
                return null;
#pragma warning restore 162
            }
            set
            {
#if !UGS_SECURITY_MODE
                var setting = new UGSettingObject();
                if (setting == null)
                {
                    throw new System.Exception(Message);
                }
                setting.ScriptURL = value;
#endif
                var __ = value;
                _scriptURL = value;
#if UNITY_EDITOR && !UGS_SECURITY_MODE
                UnityEditor.EditorUtility.SetDirty(setting);
#endif
            }
        }

        public static string ScriptPassword
        {
            get
            {
#if !UGS_SECURITY_MODE
                var _scriptPassword = System.Environment.GetEnvironmentVariable("UGS_SCRIPT_PASSWORD");
                if (_scriptPassword == null)
                {
                    throw new System.Exception(Message);
                }
                return _scriptPassword;
#endif
#pragma warning disable 162
                return null;
#pragma warning restore 162
            }
            set
            {
#if !UGS_SECURITY_MODE
                var setting = new UGSettingObject();
                if (setting == null)
                {
                    throw new System.Exception(Message);
                }
                setting.ScriptPassword = value;
                _scriptPassword = value;
#endif
                var _ = value;
#if UNITY_EDITOR && !UGS_SECURITY_MODE
                UnityEditor.EditorUtility.SetDirty(setting);
#endif
            }
        }

        public static string GenerateCodePath
        {
            get
            {
                return _generateCodePath;
            }
            set
            {
                var setting = new UGSettingObject();
                if (setting == null)
                {
                    throw new System.Exception("UGSettingObject.asset 파일을 찾을 수 없습니다. 메뉴 가이드를 따라 세팅파일을 작성해주세요. <color=#00ff00><b>HamsterLib -> UGS -> UGSetting</b></color>");
                }
                setting.GenerateCodePath = value;
                _generateCodePath = value;
#if UNITY_EDITOR && !UGS_SECURITY_MODE
                UnityEditor.EditorUtility.SetDirty(setting);
#endif
            }
        }

        public static string JsonDataPath
        {
            get
            {
                return _jsonDataPath;
            }
            set
            {
                var setting = new UGSettingObject();
                if (setting == null)
                {
                    throw new System.Exception("UGSettingObject.asset 파일을 찾을 수 없습니다. 메뉴 가이드를 따라 세팅파일을 작성해주세요. <color=#00ff00><b>HamsterLib -> UGS -> UGSetting</b></color>");
                }
                setting.DataPath = value;
                _jsonDataPath = value;
#if UNITY_EDITOR && !UGS_SECURITY_MODE
                UnityEditor.EditorUtility.SetDirty(setting);
#endif
            }
        }

        public static (string url, string pass, string driveId) GetUGSSetting()
        {
            return (UGSettingObjectWrapper.GoogleFolderID, UGSettingObjectWrapper.ScriptPassword, UGSettingObjectWrapper.ScriptURL);
        }

        public static void ClearSetting()
        {
            UGSettingObjectWrapper.ScriptPassword = null;
            UGSettingObjectWrapper.GoogleFolderID = null;
            UGSettingObjectWrapper.ScriptURL = null;
        }

        public static void CacheSettingEditorPrefs()
        {
#if UNITY_EDITOR

#endif
        }

    }
}
#endif