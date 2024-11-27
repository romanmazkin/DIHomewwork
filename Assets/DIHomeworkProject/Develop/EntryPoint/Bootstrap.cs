using Assets.DIHomeworkProject.Develop.CommonServices.LoadingScreen;
using System;
using System.Collections;
using UnityEngine;
namespace Assets.DIHomeworkProject.Develop.EntryPoint
{
    public class Bootstrap : MonoBehaviour
    {
        public IEnumerator Run(DIContainer container)
        {
            ILoadingCurtain loadingCurtain = container.Resolve<ILoadingCurtain>();
            //SceneSwitcher sceneSwitcher = container.Resolve<SceneSwitcher>();

            loadingCurtain.Show();

            Debug.Log("Run services initialization");

            //initialize all services

            //container.Resolve<PlayerDataProvider>().Load();

            yield return new WaitForSeconds(1.5f);

            //disable launch display

            Debug.Log("Services initialization is done");

            loadingCurtain.Hide();

            //sceneSwitcher.ProcessSwitchSceneFor(new OutputBootstrapArgs(new MainMenuInputArgs()));
        }
    }
}
