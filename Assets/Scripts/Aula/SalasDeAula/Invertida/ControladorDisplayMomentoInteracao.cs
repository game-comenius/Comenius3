﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ControladorDisplayMomentoInteracao : MonoBehaviour
{
    [SerializeField]private MomentoInteracao momento;
    public MomentoInteracao Momento {
            get {
                return momento;
            } 
            set {
                totalDePaginas = value.paginas.Length;
                paginaAtual = 0;
                momento = value;
                //Prepara o dropdown
                dropdown.ClearOptions();
                List<Dropdown.OptionData> listaDeEscolhas = new List<Dropdown.OptionData>();
                listaDeEscolhas.Add(new Dropdown.OptionData(""));
                listaDeEscolhas.AddRange(value.opcoesDeEscolha);
                dropdown.AddOptions(listaDeEscolhas);
            }
        }

    [System.Serializable]public class ChoiceConfirmEvent : UnityEvent<Dropdown.OptionData> {}
    public ChoiceConfirmEvent OnChoiceConfirm;


    private int paginaAtual;
    private int totalDePaginas;
    private bool ultimaPagina {
        get {
            if(paginaAtual == totalDePaginas-1)
                return true;
            else
                return false;
        }
    }

    private Dropdown.OptionData escolhaAtual;

    [SerializeField]private Text titulo;
    [SerializeField]private Text texto;
    [SerializeField]private Button setaDireita;
    [SerializeField]private Button setaEsquerda;
    [SerializeField]private Dropdown dropdown;

    private void OnValidate()//Faz atualizar o momento quando alterado pelo inspector
    {
        Momento = momento;
    }

    private void Start()
    {
        //Atualiza o display para primeira pagina
        paginaAtual = 0;
        AtualizarPagina();
        if(escolhaAtual == null)
            escolhaAtual = new Dropdown.OptionData("");

        //Faz os botões chamarem o avanco/volta pagina
        setaDireita.onClick.AddListener(AvançarPagina);
        setaEsquerda.onClick.AddListener(RetrocederPagina);
        dropdown.onValueChanged.AddListener(ValidarEscolha);
    }

    private void OnDestroy()
    {
        setaDireita.onClick.RemoveListener(AvançarPagina);
        setaEsquerda.onClick.RemoveListener(RetrocederPagina);
        dropdown.onValueChanged.RemoveListener(ValidarEscolha);
    }

    public void ValidarEscolha(int escolha)
    {
        escolhaAtual = dropdown.options[escolha];
        if(escolhaAtual.text != "")
            setaDireita.interactable = true;
        else
            setaDireita.interactable = false;
    }

    private void AtualizarPagina()
    {
        PaginaInteracao pagina = momento.paginas[paginaAtual];

        titulo.text = pagina.titulo;
        texto.text = pagina.texto;

        if(ultimaPagina) {
            dropdown.gameObject.SetActive(true);
            if(escolhaAtual.text == "")
                setaDireita.interactable = false;
        } else {
            setaDireita.interactable = true;
            dropdown.gameObject.SetActive(false);
        }
        setaEsquerda.interactable = !(paginaAtual == 0);//Seta esquerda esta ativada com excessão da primeira pagina
    }

    public void AvançarPagina()
    {
        if(ultimaPagina && escolhaAtual.text != "")
            OnChoiceConfirm.Invoke(escolhaAtual);
        

        paginaAtual ++;
        if(paginaAtual >= totalDePaginas - 1)
            paginaAtual = totalDePaginas - 1;
           
        AtualizarPagina();
    }
    public void RetrocederPagina()
    {
        paginaAtual --;
        if(paginaAtual < 0)
            paginaAtual = 0;
        AtualizarPagina();
        
    }
}