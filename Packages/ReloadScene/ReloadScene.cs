using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    [MenuItem("Tools/ReloadScene")]
    public static void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
