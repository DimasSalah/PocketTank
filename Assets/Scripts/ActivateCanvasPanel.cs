using UnityEngine;

public class ActivateCanvasPanel : MonoBehaviour
{
    public GameObject canvasPanel;
    public AudioClip powerupSound;

    public void ActivatePanel()
    {
        canvasPanel.SetActive(true);
        AudioSource.PlayClipAtPoint(powerupSound, transform.position);
    }
}
