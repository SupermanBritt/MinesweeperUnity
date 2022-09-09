using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOnClick : MonoBehaviour
{
    // public void MoveToScene()
    // {
    //     SceneManager.LoadScene(1);
    // }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
