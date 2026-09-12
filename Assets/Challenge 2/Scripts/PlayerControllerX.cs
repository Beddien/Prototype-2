using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public InputAction fireAction;
    private float cooldown = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        fireAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        cooldown = Math.Max(cooldown - Time.deltaTime, 0);
        // On spacebar press, send dog
        if (fireAction.triggered && cooldown <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldown = 0.35f;
        }
    }
}
