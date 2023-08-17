using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosions : MonoBehaviour
{
    public GameObject[] objectsToActivate;
    public float activationDuration = 3f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ActivateRandomObject();
        }
    }

    private void ActivateRandomObject()
    {
        if (objectsToActivate.Length == 0)
        {
            Debug.LogWarning("No objects assigned to objectsToActivate array.");
            return;
        }

        int randomIndex = Random.Range(0, objectsToActivate.Length);
        GameObject randomObject = objectsToActivate[randomIndex];

        StartCoroutine(ActivateAndDeactivateObject(randomObject));
    }

    private IEnumerator ActivateAndDeactivateObject(GameObject obj)
    {
        obj.SetActive(true);
        yield return new WaitForSeconds(activationDuration);
        obj.SetActive(false);
    }
}
