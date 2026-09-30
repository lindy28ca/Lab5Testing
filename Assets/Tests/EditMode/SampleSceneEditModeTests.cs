using NUnit.Framework;
using UnityEditor;

public class SampleSceneEditModeTests
{
    [Test]
    public void SampleSceneIsIncludedInBuild()
    {
        const string scenePath = "Assets/Scenes/SampleScene.unity";

        Assert.IsNotNull(AssetDatabase.LoadAssetAtPath<SceneAsset>(scenePath));
        Assert.That(EditorBuildSettings.scenes, Has.Some.Matches<EditorBuildSettingsScene>(
            scene => scene.enabled && scene.path == scenePath));
    }
}
