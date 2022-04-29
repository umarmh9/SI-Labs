using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
    public string tagFilter;

    private void OnTriggerEnter (Collider other) // OnTriggerEnter: a special unity method
    {
        if (other.CompareTag(tagFilter)) // Check the tag of the GameObject that enters the trigger
        {
            Destroy(gameObject); // destroy the object this script is attached to
        }
    }
}
