using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {

    // PUBLIC INSTANCE VARIABLES
    public float speed = 1f;

    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;
    private Vector2 _currentPosition;

    // Use this for initialization
    void Start()
    {
        // Make a reference with the Transform Component
        this._transform = gameObject.GetComponent<Transform>();

        // Reset the Island Sprite to the Top
        this.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this.speed,0);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= -260)
        {
            this.Reset();
        }
    }

    public void Reset()
    {
        float yPosition = Random.Range(-200f, 200f);
        if (this._currentPosition.x <= -200)
        this._transform.position = new Vector2(260f,yPosition);
    }
}

