using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    // Start is called before the first frame update
    public PowerupEffect powerupEffect;
    public AudioClip powerupSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(powerupSound, transform.position);
        Destroy(gameObject);
        powerupEffect.Apply(collision.gameObject);
    }
}
