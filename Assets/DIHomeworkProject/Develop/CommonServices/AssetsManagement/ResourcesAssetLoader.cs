using UnityEngine;

namespace Assets.DIHomeworkProject.Develop.CommonServices.AssetsManagement
{
    public class ResourcesAssetLoader
    {
        public T LoadResource<T>(string resourcePath) where T : Object
            => Resources.Load<T>(resourcePath);
    }
}