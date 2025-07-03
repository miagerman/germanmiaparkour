using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public GameObject interactionMessage;
    public MercanciaScript mercancia;


    void Start()
    {
        interactionMessage.SetActive(false);
    }

    void Update()
    {
    if (Input.GetKeyDown(KeyCode.E))
    {
        if (mercancia)
        {
            Destroy(mercancia.gameObject);
        }
    }
}


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

    MercanciaScript mercancia = other.GetComponent<MercanciaScript>();

    if (mercancia)
    {
        interactionMessage.SetActive(true);
    }
    }

    private void OnTriggerExit(Collider other)
    {
        StopInteraction();
    }

     void StopInteraction()
    {
        interactionMessage.SetActive(false);
        mercancia = null;
    }

}
