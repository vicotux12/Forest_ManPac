using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sword : MonoBehaviour{

    GameObject Espada;
    public string TagEspada, TagPlayer = "Jugador";
    
    [SerializeField] float waitTime;
    [SerializeField]int _Sound;
    [SerializeField] AudioClip _EnemyChange;
    [SerializeField]Text TextCargar;

    [SerializeField] GameObject colectable;
    Collider ColectableCollider, EspadaCollider;
    Renderer ColectableRenderer, EspadaRenderer;
    SoundFXManagerv FXManager;

void Awake(){
        Espada = GameObject.FindGameObjectWithTag(TagEspada);
        EspadaCollider = Espada.GetComponent<Collider>();
        ColectableCollider = colectable.GetComponent<Collider>(); 
        EspadaRenderer = Espada.GetComponent<Renderer>();
        ColectableRenderer = colectable.GetComponent<Renderer>();
        FXManager=FindObjectOfType<SoundFXManagerv>();
      }

    private void OnTriggerEnter(Collider other)
    {
      if (other.tag == TagPlayer){
        FXManager.SoundPlay(_EnemyChange, _Sound);
        StartCoroutine(VidaEnemy());
        EspadaCollider.enabled = true;
        EspadaRenderer.enabled = true;
        ColectableCollider.enabled = false;
        ColectableRenderer.enabled = false;
      }
             
    IEnumerator VidaEnemy(){
        TextCargar.text="Tu turno de atacar!";
      yield return new WaitForSeconds(waitTime);
      TextCargar.text="";
      Debug.Log("tiempo acabado");
      EspadaCollider.enabled = false;
      EspadaRenderer.enabled = false;
      Destroy(colectable);
      }

    }
    }
