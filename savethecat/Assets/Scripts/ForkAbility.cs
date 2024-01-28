using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForkAbility : MonoBehaviour
{

public Transform player;
public float speed;
public GameObject[] forks;
public bool hasAbility;
public int forksActivated;
public float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){

        if(hasAbility && forksActivated<3){

            for(int i=0;i<forks.Length;i++){
                forks[i].SetActive(true);
            if(forks[i].activeSelf==true){
                forksActivated+=1;
                }
            }

        }

        transform.position=player.position;
        if(transform.eulerAngles.z>=360){
            timer=0;
        }    timer+=Time.deltaTime;

        transform.eulerAngles=new Vector3(transform.eulerAngles.x,transform.eulerAngles.y,transform.eulerAngles.z-speed);
    
    }
}
