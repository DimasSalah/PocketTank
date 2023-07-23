using UnityEngine;
using UnityEngine.SceneManagement;


[CreateAssetMenu(menuName = "PowerupEffects/SceneSwitch")]
public class NextScene : PowerupEffect
{
    // Start is called before the first frame update
public string sceneName;

    public override void Apply(GameObject target)
    {
        SceneManager.LoadScene(sceneName);
    }
}
