using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ColliderBook5 : MonoBehaviour
{
    public GameObject Canvas1;
    bool open = false;
    public PlayerMovementScript script;
    public bool check5 = false;
     
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && open)
        {
            Canvas1.SetActive(false);
            script.enabled = true;
            check5 = true;
            SceneManager.LoadScene("End");
            SceneManager.UnloadSceneAsync("WorldMap");
            
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            script.enabled = false;
            Canvas1.SetActive(true);
            open = true;
        }

    }
}
