using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour{

[SerializeField]string TagEspada;
[SerializeField]GameObject Espada, colectable;
[SerializeField]public Renderer rend;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == TagEspada){
            rend.enabled = true;
            Espada.SetActive(true);
            Destroy(colectable);
            }
            
        }
    }
