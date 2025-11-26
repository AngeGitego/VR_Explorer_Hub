using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseClickLoadScene : MonoBehaviour
{
    public string sceneName;

    void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}
