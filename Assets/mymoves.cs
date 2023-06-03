using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mymoves : MonoBehaviour
{

    [SerializeField] private GameObject[] endpoints;
    [SerializeField] private float speed =2f;
    private int currentpoint=0;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
        if( Vector2.Distance(endpoints[currentpoint].transform.position,transform.position)<.1f  )
        {

            currentpoint++;



if(currentpoint>=endpoints.Length){

currentpoint=0;

}




        }


transform.position=Vector3.MoveTowards(transform.position,endpoints[currentpoint].transform.position,Time.deltaTime*speed);



    }
}
