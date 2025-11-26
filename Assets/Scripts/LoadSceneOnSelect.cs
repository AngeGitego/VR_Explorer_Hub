using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnSelect : MonoBehaviour
{
    public string sceneName;

    public void LoadMyScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
