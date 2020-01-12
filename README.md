# UnityChangeScenes

1. SceneLoader.cs: If you want to be able to change your scenes in Unity by clicking onto buttons. Then this is the C# code to do so.
Besides that you need to add an Event Trigger on the button and choose if you want to trigger the next scene when the button is clicked or when the button is viewed upon.
Accordingly, you create an empty GameObject and then add the script the for changing scenes onto it. Then you add that GameObject to the Event Trigger Component and then select the function that changes the scenes.

2.If you want to build a VR app on your mobile where you want to be able to change scenes from 2D to the split view. Hence,here are two codes to shift between 2D scene and VR scene.
The scripts YesVR and NoVR allow that.

REMINDER: Do not forget to assign index numbers to your scenes by going into Build Settings and then add Scenes.
