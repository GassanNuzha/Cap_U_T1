using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaferPreparation : MonoBehaviour
{
    public GameObject wafer;
    public Material cleaningMaterial;
    public Material preCleaningMaterial;
    public float cleaningTime;

    private float elapsedTime = 0f;
    private bool isCleaning = false;

    void Start()
    {
        wafer.GetComponent<Renderer>().material = cleaningMaterial;
    }
    void Update()
    {
        if (isCleaning)
        {
            elapsedTime += Time.deltaTime;

            if (elapsedTime >= cleaningTime)
            {
                wafer.GetComponent<Renderer>().material = preCleaningMaterial;
                isCleaning = false;
            }
        }
    }
    public void StartCleaning()
    {
        isCleaning = true;
        elapsedTime = 0f;
    }
}