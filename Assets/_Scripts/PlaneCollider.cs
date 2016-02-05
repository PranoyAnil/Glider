using UnityEngine;
using System.Collections;

public class PlaneCollider : MonoBehaviour {

    // PRIVATE INSTANCE VARIABLES
    private AudioSource[] _audioSources;
    private AudioSource _coinSound;
    private AudioSource _fireSound;

    // PUBLIC INSTANCE VARIABLES
    public GameController gameController;

    // Use this for initialization
    void Start()
    {
        // Initialize the audioSources array
        this._audioSources = gameObject.GetComponents<AudioSource>();
        this._coinSound = this._audioSources[1];
        this._fireSound = this._audioSources[2];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            this._coinSound.Play();
            this.gameController.ScoreValue += 100;
        }
        if (other.gameObject.CompareTag("Fire"))
        {
            this._fireSound.Play();
            this.gameController.LivesValue -= 1;
        }
    }

}
