using System.Collections;
using UnityEngine;

namespace Assets.DIHomeworkProject.Develop.CommonServices.CoroutinePerformer
{
    public interface ICoroutinePerformer
    {
        Coroutine StartPerform(IEnumerator coroutineFunction);
        void StopPerform(Coroutine coroutine);
    }
}
