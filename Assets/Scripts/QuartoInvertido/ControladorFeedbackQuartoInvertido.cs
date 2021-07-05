using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class ControladorFeedbackQuartoInvertido : MonoBehaviour
{

    [SerializeField] GameObject feedbackVisualFeliz;
    [SerializeField] GameObject feedbackVisualTriste;
    [SerializeField] GameObject feedbackDescricao;

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
                    feedbackVisualFeliz.SetActive(false);
                    feedbackVisualTriste.SetActive(true);
                    break;
                case ("Intrapessoal e Espacial-visual"):
                    feedbackDescricao.GetComponent<TextMeshProUGUI>().text = "Gostei de fazer as tarefas e ver o conteúdo antes da aula!";
                    feedbackVisualFeliz.SetActive(true);
                    feedbackVisualTriste.SetActive(false);
                    break;
                case ("Interpessoal e Musical"):
                    feedbackDescricao.GetComponent<TextMeshProUGUI>().text = "Quero fazer as tarefas ouvindo música com os meus colegas.";
                    feedbackVisualFeliz.SetActive(false);
                    feedbackVisualTriste.SetActive(true);
                    break;
                case ("Linguística e Lógico-matemática"):
                    feedbackDescricao.GetComponent<TextMeshProUGUI>().text = "Quero aprender com as histórias contadas pelo professor!";
                    feedbackVisualFeliz.SetActive(false);
                    feedbackVisualTriste.SetActive(true);
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
                    feedbackVisualFeliz.SetActive(false);
                    feedbackVisualTriste.SetActive(true);
                    break;
                case ("Intrapessoal e Espacial-visual"):
                    feedbackDescricao.GetComponent<TextMeshProUGUI>().text = "Adorei a ideia de entender e visualizar o conteúdo primeiro com atividades individuais.";
                    feedbackVisualFeliz.SetActive(true);
                    feedbackVisualTriste.SetActive(false);
                    break;
                case ("Interpessoal e Musical"):
                    feedbackDescricao.GetComponent<TextMeshProUGUI>().text = "Gostaria de ter debates e diálogos sobre o que estudei em casa.";
                    feedbackVisualFeliz.SetActive(false);
                    feedbackVisualTriste.SetActive(true);
                    break;
                case ("Linguística e Lógico-matemática"):
                    feedbackDescricao.GetComponent<TextMeshProUGUI>().text = "Quero entender o conteúdo, tirando dúvidas e fazendo as minhas anotações.";
                    feedbackVisualFeliz.SetActive(false);
                    feedbackVisualTriste.SetActive(true);
                    break;
                default:
                    feedbackDescricao.GetComponent<TextMeshProUGUI>().text = "Não foi possível obter a inteligência selecionada.";
                    break;
            }

        }

    }

}
