using UnityEngine;
using UnityEditor;
using System.IO;

public class Screenshot : MonoBehaviour
{
    [MenuItem("Tools/Screenshot")]
    public static void Capture()
    {
        // スクリーンショットを保存するフォルダを作成
        string folderPath = Application.dataPath + "/../Screenshots";
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }
        // スクリーンショットを保存
        string fileName = System.DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";
        ScreenCapture.CaptureScreenshot(folderPath + "/" + fileName);
    }
}