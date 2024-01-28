using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForkAbility : MonoBehaviour
{

public Transform player;
public float speed;
public GameObject[] forks;
public bool hasAbility;
public int forksActivated = 3;
public float lastEnabledTime = 0;
public float cooldown = 2;
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

                Debug.Log("has ability and forks <3");
            }

        }
        
        if(Time.time > lastEnabledTime + cooldown)
        {
            for(int i=0;i<forks.Length;i++){
            forks[i].SetActive(!forks[i].activeSelf);
            }
            lastEnabledTime = Time.time;
            Debug.Log("acessou o codigo");
        }

        transform.position=player.position;

        transform.eulerAngles=new Vector3(transform.eulerAngles.x,transform.eulerAngles.y,transform.eulerAngles.z-speed);
    
    }
}
