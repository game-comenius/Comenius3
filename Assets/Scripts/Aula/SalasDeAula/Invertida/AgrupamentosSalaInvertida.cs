using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AgrupamentosSalaInvertida : MonoBehaviour
{
    public GameObject agrupamentoSalaInteira;
    public GameObject agrupamentoGrandesGrupos;
    public GameObject agrupamentoPequenosGrupos;
    public GameObject agrupamentoDuplas;
    public GameObject agrupamentoIndividual;
    public int agrupamentoValor;
    GameObject agrupamentoVisualizado;   
    public Text nomeDoAgrupamento;
    public TextMeshProUGUI descricaoAgrupamento;
    
    

    public int indiceDaMidia;

    void Start()
    {
        agrupamentoValor = 1;
        MostrarAgrupamento(1);
    }

    public void MostrarAgrupamento(int agrValor)
    {
        if (agrupamentoVisualizado != null)
        {
            //Esconde o agrupamento que estva disponível antes de apertar o botão
            agrupamentoVisualizado.SetActive(false);
        }

        //Seleciona o próximo agrupamento de acordo com o int agrupamentoValor
        switch (agrValor)
        {
            case 1:
                agrupamentoVisualizado = agrupamentoSalaInteira;
                nomeDoAgrupamento.text = "Formato de U";
                //descricaoAgrupamento.text = "Esse formato proporciona contato visual entre todos e favorece o debate coletivo, colaboração, troca entre os colegas, aulas expositivas que necessitam de apoio da lousa ou outra tecnologia educacional.";
                EstadoDoJogo.Instance.MidiasSelecionadas[indiceDaMidia].agrupamento = Agrupamento.FormatoU;             
                break;
            case 2:
                agrupamentoVisualizado = agrupamentoGrandesGrupos;
                nomeDoAgrupamento.text = "Grupos Grandes";
                descricaoAgrupamento.text = "Os grupos formados por um número maior de alunos são indicados para atividades de pluralidade de olhares e debate de hipóteses sobre o objeto de aprendizagem. Habilidades como negociação, argumentação, responsabilidade compartilhada, divisão e delegação de tarefas trabalhando em equipe.";
                EstadoDoJogo.Instance.MidiasSelecionadas[indiceDaMidia].agrupamento = Agrupamento.GrandesGrupos;              
                break;

            case 3:
                agrupamentoVisualizado = agrupamentoPequenosGrupos;
                nomeDoAgrupamento.text = "Grupos Pequenos";
                descricaoAgrupamento.text = "";
                EstadoDoJogo.Instance.MidiasSelecionadas[indiceDaMidia].agrupamento = Agrupamento.PequenosGrupos;                       
                break;

            case 4:
                agrupamentoVisualizado = agrupamentoDuplas;
                nomeDoAgrupamento.text = "Duplas";
                descricaoAgrupamento.text = "Esse formato é recomendado para uma interação mais direta entre os alunos. Ideal para produção de textos, alfabetização e resolução de problemas.";
                EstadoDoJogo.Instance.MidiasSelecionadas[indiceDaMidia].agrupamento = Agrupamento.Duplas;                
                break;

            case 5:
                agrupamentoVisualizado = agrupamentoIndividual;
                nomeDoAgrupamento.text = "Individual";
                descricaoAgrupamento.text = "Permite que o educador trabalhe aulas expositivas, apresentações em vídeo, filmes e situações em que é necessário o apoio da lousa. Essa organização em alguns momentos pode limitar a interação entre alunos e entre estes e os professores.";
                EstadoDoJogo.Instance.MidiasSelecionadas[indiceDaMidia].agrupamento = Agrupamento.Individual;
                break;    
        }
        agrupamentoValor = agrValor;
        //Mostra o próximo agrupamento.
        agrupamentoVisualizado.SetActive(true);
    }

    public void BotaoProximoAgrupamento()
    {        

        if (agrupamentoValor == 5)
        {
            agrupamentoValor = 0;
        }

        agrupamentoValor++;        

        MostrarAgrupamento(agrupamentoValor);        
    }

    public void BotaoAgrupamentoAnterior()
    {        
        if (agrupamentoValor == 1)
        {
            agrupamentoValor = 6;
        }

        agrupamentoValor--;       
        
        MostrarAgrupamento(agrupamentoValor);
    }  
    
}
