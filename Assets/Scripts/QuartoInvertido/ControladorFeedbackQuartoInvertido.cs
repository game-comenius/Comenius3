using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class ControladorFeedbackQuartoInvertido : MonoBehaviour
{

    [SerializeField] GameObject feedbackVisual;
    [SerializeField] GameObject feedbackDescricao;

    [Header("Retratos dos alunos")]
    public Sprite alunoFeliz;
    public Sprite alunoNeutro;

    // Start is called before the first frame update
    void Start()
    {

        var estadoDoJogo = EstadoDoJogo.Instance;
        string nomeInteligencia = estadoDoJogo.InteligenciasSelecionadas.Nome;

        if (estadoDoJogo.NivelDeEnsinoSelecionado.nome == "Educação Infantil" || estadoDoJogo.NivelDeEnsinoSelecionado.nome == "Ensino Fundamental") 
        {

            switch(nomeInteligencia)
            {
                case ("Corporal-cinestésica e Naturalista"):
                    feedbackDescricao.GetComponent<TextMeshProUGUI>().text = "Quero me movimentar, brincando lá fora!";
                    feedbackVisual.GetComponent<Image>().sprite = alunoNeutro;
                    break;
                case ("Intrapessoal e Espacial-visual"):
                    feedbackDescricao.GetComponent<TextMeshProUGUI>().text = "Gostei de fazer as tarefas e ver o conteúdo antes da aula!";
                    feedbackVisual.GetComponent<Image>().sprite = alunoFeliz;
                    break;
                case ("Interpessoal e Musical"):
                    feedbackDescricao.GetComponent<TextMeshProUGUI>().text = "Quero fazer as tarefas ouvindo música com os meus colegas.";
                    feedbackVisual.GetComponent<Image>().sprite = alunoNeutro;
                    break;
                case ("Linguística e Lógico-matemática"):
                    feedbackDescricao.GetComponent<TextMeshProUGUI>().text = "Quero aprender com as histórias contadas pelo professor!";
                    feedbackVisual.GetComponent<Image>().sprite = alunoNeutro;
                    break;
                default:
                    feedbackDescricao.GetComponent<TextMeshProUGUI>().text = "Não foi possível obter a inteligência selecionada.";
                    break;
            }

        } else if (estadoDoJogo.NivelDeEnsinoSelecionado.nome == "Ensino Médio" || estadoDoJogo.NivelDeEnsinoSelecionado.nome == "Ensino Superior")
        {

            switch (nomeInteligencia)
            {
                case ("Corporal-cinestésica e Naturalista"):
                    feedbackDescricao.GetComponent<TextMeshProUGUI>().text = "Gostaria de realizar atividades a céu aberto, em contato com a natureza.";
                    feedbackVisual.GetComponent<Image>().sprite = alunoNeutro;
                    break;
                case ("Intrapessoal e Espacial-visual"):
                    feedbackDescricao.GetComponent<TextMeshProUGUI>().text = "Adorei a ideia de entender e visualizar o conteúdo primeiro com atividades individuais.";
                    feedbackVisual.GetComponent<Image>().sprite = alunoFeliz;
                    break;
                case ("Interpessoal e Musical"):
                    feedbackDescricao.GetComponent<TextMeshProUGUI>().text = "Gostaria de ter debates e diálogos sobre o que estudei em casa.";
                    feedbackVisual.GetComponent<Image>().sprite = alunoNeutro;
                    break;
                case ("Linguística e Lógico-matemática"):
                    feedbackDescricao.GetComponent<TextMeshProUGUI>().text = "Quero entender o conteúdo, tirando dúvidas e fazendo as minhas anotações.";
                    feedbackVisual.GetComponent<Image>().sprite = alunoNeutro;
                    break;
                default:
                    feedbackDescricao.GetComponent<TextMeshProUGUI>().text = "Não foi possível obter a inteligência selecionada.";
                    break;
            }

        }

    }

}
