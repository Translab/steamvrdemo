# Fall 2018 steamVRdemo
A starter project for unity tutorials

## Version Required:
Unity 2018.2.12f1
(You can use Unity Hub to manage versions on your computer) -- [Go to page of Unity Hub](https://store.unity.com/download?ref=personal).

## Libraries Reference:
SteamVR 2.1

## Instructions
#### Install steamVR
1. open up an empty new project, create a new scene as playground
2. delete Main Camera from the scene, as we will be using VR camera instead.
3. go to the asset tab, search steamVR plugin, download and install. A folder named "steamVR" will show up

#### Create action sets (you only need to do this at the very first time)
1. on the menu, go to Window - SteamVR Input
2. a window shows up and we see different action sets, you can create your own action set and modify it, but usually we just use "default" set directly
3. click save and generate. wait for steamVR to generate code for interaction scripts.

#### Add / Modify action sets for touchpad press and touchpad position
1. on the menu, go to Window - SteamVR Input
2. in the actions section, click the little "+" icon, you will be able to add a new action for controller.
3. give it a name as "TouchPad", type as "boolean", localized string as "touchpad"
4. click the little "+" icon again, create another action named "TouchPos", type as "vector2", localized string as "touchpos"
5. click save and generate.

#### Change Controller button bindings after adding actions
1. on the menu, go to Window - SteamVR Input
2. make sure your steam app is running, click "Open binding UI"
3. a webpage will pop up, at the card of "vive_controller", click edit
4. on left side, scroll down to "Trackpad" section, there is "TRACKPAD" card, and you see "click", "touch", "position" three actions
5. set Click to be "teleport", Touch to be "touchpad", Position to be "touchpos"
6. save the bindings and click "Go back" on the top. Quit.

#### Check your touchpad press and touchpad position tracking
1. in the Assets folder, go to Steam folder, open "simple sample" scene
2. if you have HTC vive connected, you can run the scene.
3. on the menu, go to Window - steamVR input live view
4. you will see if you touch / have contact(not press) on the touchpad, the value will change from false to true
5. same as the touchpos, a 2D vector value will change based on your touch area

#### Advanced Interaction
1. in the Assets folder, go to SteamVR - InteractionSystem - Samples, open InteractionExample scene
2. in the scene, you will see a bunch of objects available as examples for interaction
3. Player object is the core object we want, as it contains steamVR camera object and controller objects that are necessary for VR interaction
4. you should learn how different script objects are placed and structured in the Player object, how they reference each other
5. The demoVR scene in the project provides a simplified working version of the Player object, named as "VR Player", you can start from that object and see if you can understand how it works.

#### Scripting & XRTK interface, we will discuss on Wednesday Oct 31, 2018 1-2pm