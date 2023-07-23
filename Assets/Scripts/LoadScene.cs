using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    public string targetScene;

    public void SwitchScene()
    {
        SceneManager.LoadScene(targetScene);
    }
}
