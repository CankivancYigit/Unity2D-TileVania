using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip coinTakeSFX;
    [SerializeField] int coinPoint = 50;
    private void OnTriggerEnter2D(Collider2D other)
    {
        AudioSource.PlayClipAtPoint(coinTakeSFX, Camera.main.transform.position);
        Destroy(gameObject);    
        FindObjectOfType<GameSession>().AddToScore(coinPoint);
    }
}
