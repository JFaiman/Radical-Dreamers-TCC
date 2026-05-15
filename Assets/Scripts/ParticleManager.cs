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
            Great1.Emit(emitParams,22);
            Great1.Play();
            Great2.Emit(emitParams,4000);
            Great2.Play();
        }
        if (whatToEmit == 2)
        {
            Good1.Emit(emitParams, 22);
            Good1.Play();
            Good2.Emit(emitParams, 4000);
            Good2.Play();
        }
    }
}
