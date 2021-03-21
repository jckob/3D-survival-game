using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ColliderBook2 : MonoBehaviour
{
    public GameObject Canvas1;
    bool open = false;
    public PlayerMovementScript script;
    public bool check2 = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && open)
        {
            Canvas1.SetActive(false);
            script.enabled = true;
            check2 = true;
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
