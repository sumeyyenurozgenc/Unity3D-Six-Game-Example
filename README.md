# Unity3D-Six-Game-Example
https://github.com/sumeyyenurozgenc/Unity3D-Six-Game-Example/issues
Hi everyone. I am going to talk about six! game. I tried to write it with my code style. This game is 2D. therefore objects and added components will be 2-dimensional. For example Rigidbody2D and BoxCollider2D.

This is the first view of the project in Unity3D.
![screen](https://user-images.githubusercontent.com/59045890/95026228-99333e00-0698-11eb-9973-9fa4a4d67132.png)

I created these shapes using unit squares by activating the Grids on PhotoShop. For now I have created 4 shapes and these are inside gameobjects. Each of them consists of a combination of different square shapes. For example smallL shape, square shape etc.
![third](https://user-images.githubusercontent.com/59045890/95026458-304cc580-069a-11eb-9d5b-d38549b71acc.png)

For example; when I clicked the Shape1, I will see what shapes it consists of.

![shape1](https://user-images.githubusercontent.com/59045890/95026473-4a86a380-069a-11eb-8843-170640cdfc0b.png)
![shape1sd](https://user-images.githubusercontent.com/59045890/95026475-4c506700-069a-11eb-94ee-1cd9079369cb.png)

When I run the program, my prefabs will appear on the screen. I wrote the appropriate code for a smoother transition between colors.

![second](https://user-images.githubusercontent.com/59045890/95026300-1363c280-0699-11eb-937c-90d70296f80d.png)

#### Each object has Particular System. Particular System creates an explosion effect when exploding objects. I added Audio Source in addition to Particular System and every explosion to hear popping sound. Thus, when I detonate an object, I will see a visual explosion effect and hear an explosion sound.

<p align="left">
  <img src="https://user-images.githubusercontent.com/59045890/95026968-aef73200-069d-11eb-9732-7faea3f9e1d0.png" width="210" title="tld">
  <img src="https://user-images.githubusercontent.com/59045890/95026969-b0285f00-069d-11eb-80a1-9dae329254a8.png" width="210" title="tld">
  <img src="https://user-images.githubusercontent.com/59045890/95026970-b0c0f580-069d-11eb-8488-312557f52716.png" width="210" title="tld">
  <img src="https://user-images.githubusercontent.com/59045890/95026971-b0c0f580-069d-11eb-8129-31139e122f18.png" width="210" title="tld">
</p>

The camera follows our hex along the y axis.
When hex falls into space and hits colliders, the game will be over and the Try Again button will appear on the screen. I used Enum to leave the game at the last camera position. There are 2 situations here as Start and GameOver. As long as it is not GameOver, it can explode shapes and the camera will follow the hex. If there is a gameover, the Try Again Panel will be activated. The camera will take the final y-axis position of hex before it is game over and will not be able to explode any shapes in the back. If I didn't use such a condition, I would continue to explode shapes even if I was finished in the game.

<p align="left">
  <img src="https://user-images.githubusercontent.com/59045890/95026701-e1079480-069b-11eb-8cf6-da81f94277ab.png" width="210" title="finish">
</p>

### CubeBoom.cs
#### Cube1, Cube2, dikey, Dikey3, smallL, tShape, UShape has CubeBoom.cs, BoxCollider (I arranged for every shape and added 2 BoxCollider to some shapes), Sprite Renderer to add figure, Rigidbody2D to fall according to the laws of physics.

![CubeBoom](https://user-images.githubusercontent.com/59045890/95594666-ed9d3b80-0a53-11eb-8e0e-7c54c105f332.png)

### FollowHex.cs
This script is in Main Camera. Its purpose is to follow the hex and create shapes without running the program.

![FollowHex](https://user-images.githubusercontent.com/59045890/95594667-eece6880-0a53-11eb-9673-7f3516daff8e.png)
