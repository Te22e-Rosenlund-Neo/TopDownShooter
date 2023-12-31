using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class PlayerMove : MonoBehaviour
{

    float TimeBetweenShots = 0.3f;
    float TimeSinceLastShot;
    [SerializeField] GameObject Bolt;
    [SerializeField] GameObject Gun;
    float Speed = 6;
    public int PlayerHealth = 10;
    public bool PossibleShooting = true;
    void Update()
    {
        
        


        float MoveX = Input.GetAxisRaw("Horizontal");
        float MoveY = Input.GetAxisRaw("Vertical");



          Vector2 MovementX = new Vector2(Speed,0)* MoveX * Time.deltaTime;
          Vector2 MovementY = new Vector2(0,Speed) * MoveY * Time.deltaTime;

          Vector2 TotalMovement = MovementX + MovementY;
          transform.Translate (TotalMovement,Space.World);
        


        Vector2 MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 Direction = new Vector2(transform.position.x - MousePosition.x, transform.position.y - MousePosition.y);
        transform.up = Direction;

        if(Input.GetKey(KeyCode.LeftShift)){
          Speed = 10;
          PossibleShooting = false;
        }else{
          Speed = 6;
          PossibleShooting = true;
        }





        TimeSinceLastShot += Time.deltaTime;
        if(Input.GetAxisRaw("Fire1")>0 && TimeSinceLastShot > TimeBetweenShots && PossibleShooting == true){

        TimeSinceLastShot = 0;
        Instantiate(Bolt, Gun.transform.position, Quaternion.identity);

        }

        if(PlayerHealth <= 0){
          Destroy(gameObject);
        }
        
     



    }



}


  