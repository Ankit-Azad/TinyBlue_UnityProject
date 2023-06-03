using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item_collector : MonoBehaviour
{
    [SerializeField] private AudioSource itemsound;
    [SerializeField] private Text cherries_text;
    private int cherries_collected=0;
    // Start is called before the first frame update
private void Start(){


}
    private void OnTriggerEnter2D(Collider2D collision )
    {
        
    if (collision.gameObject.CompareTag("cherry")){
Destroy(collision.gameObject);
cherries_collected++;
cherries_text.text="cherries: "+cherries_collected;

itemsound.Play();
    }
        
    }
}
