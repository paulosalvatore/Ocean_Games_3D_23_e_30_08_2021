using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canhao : MonoBehaviour
{
    public Transform spawnTransform;

    public GameObject prefabSpawn;

    public float delayInicial = 3f;

    public float delayEntreObjetos = 2f;

    public float forcaEmpurrarObjeto = 100;

    void Start()
    {
        InvokeRepeating("Spawn", delayInicial, delayEntreObjetos);
    }

    void Spawn()
    {
        var objeto = Instantiate(prefabSpawn, spawnTransform.position, spawnTransform.rotation);

        var rb = objeto.GetComponent<Rigidbody>();

        rb.AddRelativeForce(Vector3.up * forcaEmpurrarObjeto);
    }
}
