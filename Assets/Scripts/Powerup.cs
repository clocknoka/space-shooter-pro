using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//*
// Powerup.cs
//*
// Class behaviour
//*
// @category   Space Shooter Pro
// @tutorial   GameDevHQ
// @author     Dave González
// @copyright  2020 Dave González
// @version    CVS: 1.0
// @link       website
//*

public class Powerup : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.0f;

    [SerializeField] //0= Triple Shot , 1 = Speed , 2 = Shield
    private int powerupID;

    [SerializeField]
    private AudioClip _powerupAudioClip;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (transform.position.y < -4.5f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Player player = other.transform.GetComponent<Player>();

            AudioSource.PlayClipAtPoint(_powerupAudioClip, transform.position);

            if (player != null)
            {
                switch (powerupID)
                {
                    case 0:
                        player.TripleShotActive();
                        break;
                    case 1:
                        player.SpeedBoostActive();
                        break;
                    case 2:
                        player.ShieldsActive();
                        break;
                    default:
                        break;
                }
            }

            Destroy(this.gameObject);
        }
    }
}
