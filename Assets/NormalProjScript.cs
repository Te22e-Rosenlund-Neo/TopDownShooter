using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalProjScript : MonoBehaviour
{
GameObject Player;
[SerializeField] string Playertag;
[SerializeField] string Bordertag;
public int Projspeed = 6;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Vector2 Direction = new Vector2(Player.transform.position.x - transform.position.x, Player.transform.position.y - transform.position.y);
        transform.up = Direction;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 ShotMove = new Vector2(0, Projspeed) * Time.deltaTime;
        transform.Translate(ShotMove);        



    }


 void OnTriggerEnter2D(Collider2D other) {
    
    if(other.tag == Playertag){
        other.GetComponent<PlayerMove>().PlayerHealth --;
        Destroy(this.gameObject);
    }
    if(other.tag == Bordertag){
        Destroy(this.gameObject);
    }

}



}
