using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screen2 : MonoBehaviour
{
    public GameObject screen_1;
    public GameObject screen_2;
    public GameObject screen_3;
    public GameObject screen_4;
    float ran_num;
    float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        screen_2.SetActive(false);
        screen_3.SetActive(false);
        screen_4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AI(int num)
    {

        ran_num = Random.Range(1,4);
        if(num == 1){
            if(ran_num ==1){
                score +=0.5f;
                screen_4.SetActive(true);
            }
            else if(ran_num == 2){
                score +=1.0f;
                screen_2.SetActive(true);
            }
            else{
                score +=0.0f;
                screen_3.SetActive(true);
            }
            
        }
        else if(num ==2){
            if(ran_num ==2){
                score +=0.5f;
                screen_4.SetActive(true);
            }
            else if(ran_num == 1){
                score +=0.0f;
                screen_3.SetActive(true);
            }
            else{
                score +=1.0f;
                screen_2.SetActive(true);
            }
        }
        else{
            if(ran_num ==3){
                score +=0.5f;
                screen_4.SetActive(true);
            }
            else if(ran_num == 1){
                score +=0.0f;
                screen_3.SetActive(true);
            }
            else{
                score +=1.0f;
                screen_2.SetActive(true);
            }
        }
    }
    public void re_screen()
    {
        screen_2.SetActive(false);
        screen_3.SetActive(false);
        screen_4.SetActive(false);
        screen_1.SetActive(true);
    }
}
