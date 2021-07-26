using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FeedbackTextualLurdinha : MonoBehaviour
{
    [SerializeField] Text texto;

    private EstadoDoJogo jogo;
    private Midia midia1;
    private Midia midia2;
    private Midia midia3;
    private Midia midia4;

    private string feedback;

    private void Awake()
    {
        jogo = EstadoDoJogo.Instance;
        midia1 = jogo.MidiasSelecionadas[0];
        midia2 = jogo.MidiasSelecionadas[1];
        midia3 = jogo.MidiasSelecionadas[2];
        midia4 = jogo.MidiasSelecionadas[3];
        feedback = "";
    }

    public void Atualizar()
    {
        bool producao = usouProducao();
        bool digital = usouDigital();
        if(producao && digital)
        {
            feedback = "Parabéns! Você oportunizou pesquisas de qualidade em conteúdos online e os usou depois na sala de aula para produzir com seus alunos e tirar as dúvidas.\n";
        } else if(producao) 
        {
            feedback = "Muito bem! Os alunos puderam produzir excelentes atividades sobre o assunto.\n";
        } else if(digital)
        {
            feedback = "Muito bem! Os alunos gostaram de pesquisar os conteudos e usar as ferramentas que voce ofereceu.\n";
        } else
        {
            feedback = "Boa aula prof.! Pense na escolha de mídias que ajudem que os alunos pesquisem em casa para realizar atividades em sala de aula.\n";
        }

        if(usouMidiasErradas())
        {
            feedback += "Cuidado para escolher mídias que conectem o que foi feito em casa com as atividades em aula. Crie momentos em que você possa intervir para mediar à aprendizagem.\n";
        }

        if(midiasRepetidas())
        {
            feedback += "Procure oportunizar aos alunos o contato com diferentes mídias.\n";
        }

        texto.text = feedback;
    }

    private bool usouProducao()
    {
        bool returnValue = false;
        returnValue = returnValue || midia3.NomeMidia == NomeDeMidia.CadernosECartazes;
        returnValue = returnValue || midia3.NomeMidia == NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas;
        returnValue = returnValue || midia3.NomeMidia == NomeDeMidia.EditoresDeAudioEVideo;

        returnValue = returnValue || midia4.NomeMidia == NomeDeMidia.CadernosECartazes;
        returnValue = returnValue || midia4.NomeMidia == NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas;
        returnValue = returnValue || midia4.NomeMidia == NomeDeMidia.EditoresDeAudioEVideo;

        return returnValue;
    }
    private bool usouDigital()
    {
        bool returnValue = false;
        returnValue = returnValue || midia1.NomeMidia == NomeDeMidia.Aplicativos;
        returnValue = returnValue || midia1.NomeMidia == NomeDeMidia.AVEAs;
        returnValue = returnValue || midia1.NomeMidia == NomeDeMidia.RedesSociais;
        returnValue = returnValue || midia1.NomeMidia == NomeDeMidia.Jogos;

        returnValue = returnValue || midia2.NomeMidia == NomeDeMidia.Aplicativos;
        returnValue = returnValue || midia2.NomeMidia == NomeDeMidia.AVEAs;
        returnValue = returnValue || midia2.NomeMidia == NomeDeMidia.RedesSociais;
        returnValue = returnValue || midia2.NomeMidia == NomeDeMidia.Jogos;

        return returnValue;
    }

    private bool midiasRepetidas()
    {
        bool returnValue = false;
        returnValue = returnValue || midia1.NomeMidia == midia2.NomeMidia;
        returnValue = returnValue || midia1.NomeMidia == midia3.NomeMidia;
        returnValue = returnValue || midia1.NomeMidia == midia4.NomeMidia;
        returnValue = returnValue || midia2.NomeMidia == midia3.NomeMidia;
        returnValue = returnValue || midia2.NomeMidia == midia4.NomeMidia;
        returnValue = returnValue || midia3.NomeMidia == midia4.NomeMidia;
        return returnValue;
    }

    private bool usouMidiasErradas()
    {
        bool returnValue = false;
        returnValue = returnValue || midia3.NomeMidia == NomeDeMidia.Televisao;
        returnValue = returnValue || midia3.NomeMidia == NomeDeMidia.AparelhoDeSom;

        returnValue = returnValue || midia4.NomeMidia == NomeDeMidia.Televisao;
        returnValue = returnValue || midia4.NomeMidia == NomeDeMidia.AparelhoDeSom;

        returnValue = returnValue || midia1.NomeMidia == NomeDeMidia.EditoresDeAudioEVideo;
        returnValue = returnValue || midia1.NomeMidia == NomeDeMidia.LivroDidatico;

        returnValue = returnValue || midia2.NomeMidia == NomeDeMidia.EditoresDeAudioEVideo;
        returnValue = returnValue || midia2.NomeMidia == NomeDeMidia.LivroDidatico;

        return returnValue;
    }
}
