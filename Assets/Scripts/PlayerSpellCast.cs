using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerSpellCast : MonoBehaviour
{
    public GameObject spellCastPrefab;
    public Transform spellCastSpawn;
    public Rigidbody spellCastClone;
    public float castVelocity;
    

    // Start is called before the first frame update
    void Start()
    {
      
        spellCastClone = spellCastPrefab.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e"))
        {
            SpellCast();
        }
    }

    void SpellCast()
    {
        // Spawn a spell and add force to propel it forward from the player.
        var liveSpell = Instantiate(spellCastClone, spellCastSpawn.position, transform.rotation);
        liveSpell.GetComponent<Rigidbody>().AddForce(Vector3.forward * castVelocity, ForceMode.Impulse);
    }

}
