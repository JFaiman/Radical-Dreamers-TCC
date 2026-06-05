using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    [SerializeField] ParticleSystem Great1;
    [SerializeField] ParticleSystem Great2;
    [SerializeField] ParticleSystem Good1;
    [SerializeField] ParticleSystem Good2;


    public void EmitParticles(int whatToEmit, Vector3 whereToEmit)
    {
        var emitParams = new ParticleSystem.EmitParams();
        emitParams.position = whereToEmit;
        if(whatToEmit == 1)
        {
            Great1.Emit(1);
            Great1.Play();
            Great2.Emit(4);
            Great2.Play();
        }
        if (whatToEmit == 2)
        {
            Good1.Emit(1);
            Good1.Play();
            Good2.Emit(4);
            Good2.Play();
        }
    }
}