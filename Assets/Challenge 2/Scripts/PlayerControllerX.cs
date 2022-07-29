using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Dog prefab (proyectile)")]
    private GameObject dogPrefab;
    [SerializeField]
    [Tooltip("Dog spawning delay")]
    private float dogDelay;
    private float nextDog;

    void Start()
    {
        nextDog = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextDog)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            nextDog = Time.time + dogDelay;
        }
    }
}
