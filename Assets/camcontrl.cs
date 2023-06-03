using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camcontrl : MonoBehaviour
{
    [SerializeField] private Transform play;
    // Start is called before the first frame update
 

    // Update is called once per frame
    private void Update()
    {
        
transform.position=new Vector3(play.position.x,play.position.y,transform.position.z);


    }
}
