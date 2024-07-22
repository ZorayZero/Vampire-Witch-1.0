using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpellCollect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // if the player collides with a spell send a message and store the spell
        if (collision.gameObject.name == "Spell")
        {
            Debug.Log("ooh you touched lol");
            
        }
        
    }
}
