using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{

    public GameObject explosions;
    public GameObject playerexplosions;
    public int scoreValue;
    private GameController gameController;

    void Start()
    {
        GameObject gamecontrollerobject = GameObject.FindWithTag("GameController");
        if (gamecontrollerobject != null)
        {
            gameController = gamecontrollerobject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("cannot fjnd gamecontroller script");
        }
    }
    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bound")  || other.CompareTag("Enemy"))
        {
            return;
            
        }
        if (explosions != null)
        {
            Instantiate(explosions, transform.position, transform.rotation);
            
        }
        if (other.CompareTag("Player"))
        {
            Instantiate(playerexplosions, transform.position, transform.rotation);
            gameController.GameOver();
        }
        gameController.addscore(scoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject);

    }
}
    