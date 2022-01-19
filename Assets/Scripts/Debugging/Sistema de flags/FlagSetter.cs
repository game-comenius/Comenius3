using UnityEngine;

public class FlagSetter : MonoBehaviour
{
    [SerializeField] string nomeDaFlag;
    [SerializeField] bool estado;
    [SerializeField] bool callOnStart;

    private void Start()
    {
        if(callOnStart)
            Set();
    }

    public void Set()
    {
        foreach(var flag in EstadoDoJogo.Instance.flags)
        {
            if(flag.nome == nomeDaFlag)
            {
                flag.valor = estado;
                return;
            }
        }

        EstadoDoJogo.Instance.flags.Add(new FlagDeEstadoDeJogo(nomeDaFlag, estado));
    }
}
