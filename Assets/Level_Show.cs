using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Level_Show : MonoBehaviour
{
    [SerializeField] private Text Level_text;
    // Start is called before the first frame update
    void Start()
    {
        

Level_text.text="Level: "+SceneManager.GetActiveScene().buildIndex;

    }

    
}
