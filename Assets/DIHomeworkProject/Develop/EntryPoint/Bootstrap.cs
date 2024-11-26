using System;
using System.Collections;
using UnityEngine;
namespace Assets.DIHomeworkProject.Develop.EntryPoint
{
    public class Bootstrap : MonoBehaviour
    {
        public IEnumerator Run(DIContainer container)
        {
            //ILoadingCurrtain loadingCurrtain = container.Resolve<ILoadingCurrtain>();
            //SceneSwitcher sceneSwitcher = container.Resolve<SceneSwitcher>();

            //loadingCurrtain.Show();

            Debug.Log("Run services initialization");

            //initialize all services

            //container.Resolve<PlayerDataProvider>().Load();

            yield return new WaitForSeconds(1.5f);

            //disable launch display

            Debug.Log("Services initialization is done");

            //loadingCurrtain.Hide();

            //sceneSwitcher.ProcessSwitchSceneFor(new OutputBootstrapArgs(new MainMenuInputArgs()));
        }
    }
}
