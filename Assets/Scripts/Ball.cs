using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    float velocidade = 5f;
    bool bolaFoiLancada = false;

    [SerializeField]
    float tempo = 0f;
    float tempoEspera =2f;

    // Start is called before the first frame update
    void Start()
    {
        //if(Random.value < 0.5f)
        //{
        //    GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.right;
        //} else
        //{
        //    GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.left;
        //}

    }

    // Update is called once per frame
    void Update()
    {
        if(bolaFoiLancada == false)
        {
            tempo += Time.deltaTime;

            if(tempo >= tempoEspera)
            {
                GetComponent<Rigidbody2D>().velocity = velocidade * Random.insideUnitCircle;
                bolaFoiLancada = true;


            }

        }
    }
}
