using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victory : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvasPanel;
    public AudioClip powerupSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        canvasPanel.SetActive(true);
        AudioSource.PlayClipAtPoint(powerupSound, transform.position);
    }
}
