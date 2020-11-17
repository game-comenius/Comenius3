using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class BarraQualidadeDaAula : MonoBehaviour
{
    [SerializeField] [Range(0, 1)] float velocidadeDaBarra = 1;

    [Header("Animators & Animações")]
    [SerializeField] Animator animatorEstrelaProfessor;
    [SerializeField] string nomeAnimacaoEstrelaProfessor;
    [SerializeField] Animator animatorEstrelaBarra;
    [SerializeField] string nomeAnimacaoEstrelaBarra;

    private Slider slider;

    private Aula aula;

    // Valor da barra é de 0 a 1
    private float valor;
    public float Valor
    {
        get => valor;
        set
        {
            valor = value;
            slider.value = value;
        }
    }

    private void Awake()
    {
        slider = GetComponent<Slider>();

        aula = (Aula) FindObjectOfType(typeof(Aula));
    }

    // Barra começa vazia
    void Start()
    {
        this.Valor = 0;
        PosicionarEstrelaSobreProfessor();
        PreencherBarraAoLongoDaAula();
    }

    private void PreencherBarraAoLongoDaAula()
    {
        var quantidadeDeFragmentos = aula.Quizzes.Length + 1;

        var pontuacaoDaAula = aula.ObterPontuacaoDaAula();

        var tamanhoDoFragmento = pontuacaoDaAula / quantidadeDeFragmentos;

        // Preencher 1 fragmento no início da aula
        StartCoroutine(PreencherBarra(tamanhoDoFragmento));

        // Preencher os outros fragmentos após cada um dos quizzes da aula
        aula.UmQuizFoiAplicadoComSucessoEvent += (quiz) => StartCoroutine(PreencherBarra(tamanhoDoFragmento));
    }

    private IEnumerator PreencherBarra(float quantidade)
    {
        // Executar animação da estrela do professor e esperar ela terminar antes de continuar
        animatorEstrelaProfessor.Play(nomeAnimacaoEstrelaProfessor);

        // Tocar SFX das estrelas
        AudioManager.instance.TocarSFX("estrela");

        yield return new WaitUntil(() => animatorEstrelaProfessor.GetCurrentAnimatorStateInfo(0).IsName(nomeAnimacaoEstrelaProfessor));
        yield return new WaitForSeconds(animatorEstrelaProfessor.GetCurrentAnimatorStateInfo(0).length * (1 - animatorEstrelaProfessor.GetCurrentAnimatorStateInfo(0).normalizedTime));

        // Animar preenchimento da barra
        var tempoParaPreencher = 1 / velocidadeDaBarra;
        var objetivo = this.Valor + quantidade;
        if (objetivo > 1) objetivo = 1;

        animatorEstrelaBarra.Play(nomeAnimacaoEstrelaBarra);
        while (this.Valor < objetivo)
        {
            yield return null;
            this.Valor += (quantidade / tempoParaPreencher) * Time.deltaTime;
        }
        if (this.Valor > objetivo) this.Valor = objetivo;
    }

    private void PosicionarEstrelaSobreProfessor()
    {
        var professorGO = FindObjectOfType<Personagem>();
        if (!professorGO) return;

        var estrela = animatorEstrelaProfessor.GetComponent<RectTransform>();
        // Definir posição da estrela sobre o professor: x (unidades do world space) sobre o professor
        var worldPoint = new Vector2(professorGO.transform.position.x, professorGO.transform.position.y + 1.7f);
        // Converter o ponto para um ponto na tela (em pixels)
        var screenPoint = Camera.main.WorldToScreenPoint(worldPoint);
        // Converter o ponto na tela para a posição local onde a estrela deve ficar levando em consideração as localizações de seus pais, avós, ...
        RectTransformUtility.ScreenPointToLocalPointInRectangle(estrela.parent as RectTransform, screenPoint, null, out Vector2 localPoint);
        // Mudar posição local (anchoredPosition?) da estrela na tela para simular como se ela estivesse sobre o professor (que está no world space)
        estrela.localPosition = localPoint;
    }
}
