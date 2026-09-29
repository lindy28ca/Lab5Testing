using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class SampleScenePlayModeTests
{
    [UnityTest]
    public IEnumerator SampleSceneLoadsWithMainCamera()
    {
        yield return SceneManager.LoadSceneAsync("SampleScene");

        Assert.AreEqual("Assets/Scenes/SampleScene.unity", SceneManager.GetActiveScene().path);
        Assert.IsNotNull(Camera.main, "The loaded scene must contain an active Main Camera.");
    }
}
