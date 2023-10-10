using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.UI;
public class BossScript : MonoBehaviour
{

public int Health = 100;


[SerializeField] Slider healthbar;
[SerializeField] GameObject projectile1;
[SerializeField] GameObject projectile2;
[SerializeField] GameObject projectile3;
[SerializeField] Sprite Phase2;
[SerializeField] Sprite Dead;
private bool PhaseChange = false; 
void Awake(){
  GameObject Player = GameObject.FindWithTag("Player");

}

void Update(){
    healthbar.value = Health;

 if(Health <= 50){
        GetComponent<SpriteRenderer>().sprite = Phase2;
        PhaseChange = true;
    }

    if(Health <= 0){
        GetComponent<SpriteRenderer>().sprite = Dead;
    }
if(PhaseChange == false){
    Attack3();
    PhaseChange = true;
}
}





void Attack1(){
  
      Instantiate(projectile1,transform.position,Quaternion.identity);


}
void Attack2(){

  Instantiate(projectile2,transform.position,Quaternion.identity);
}
void Attack3(){

Instantiate(projectile3,transform.position,Quaternion.identity);
}
void Attack4(){

}
}
