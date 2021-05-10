using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProximity : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float playerPos = player.transform.position.x;
        float objPos = transform.position.x;
        float proximity = Mathf.Abs(playerPos - objPos);
        proximity /= 10.0f;
        if (proximity > 1.0f) proximity = 1.0f;
        var emitter = GetComponent<FMODUnity.StudioEventEmitter>();
        emitter.SetParameter("EnemyProximity", proximity);
    }
}
