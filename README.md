# Monster Chase
The main aim of this project is to create a game using pixelated assets obtained using the code written using Machine Leanring and Cycle GANs.  

# Technology
Unity 2D <br />
Machine Learning <br />
Cycle GANs

# Language
C#

# ML Code 
This code trains on a normal image dataset and a pixel dataset using cycle GANs and converts the given assets to their pixelated forms.

## Datasets
Train: <br />
Label A: https://www.kaggle.com/sarthak4u/aimages<br />
Label B: https://www.kaggle.com/chandinirongali/pixeldataset<br />
Epochs : 10 <br />
Lambda : 2e-4 <br />
Batch  size : 10

## Outputs

![background image pixel](https://user-images.githubusercontent.com/84968542/152483357-d6099717-af4c-4c99-a2b1-560df280dca2.jpeg)
![characters pixel](https://user-images.githubusercontent.com/84968542/152483414-d17accfa-f41c-451a-82c5-21eff6ae719f.jpg)
![ground pixel](https://user-images.githubusercontent.com/84968542/152483429-5faafba5-7632-4692-926b-0e09d44620b1.jpeg)
![home pixel](https://user-images.githubusercontent.com/84968542/152483473-fc9332ea-970b-4976-9b22-523d6fccba10.jpeg)
![restart pixel](https://user-images.githubusercontent.com/84968542/152483496-f28f22b4-da23-4352-a99d-8800f01e7557.jpeg)
![moon pixel](https://user-images.githubusercontent.com/84968542/152483516-2a905438-6c36-4a4c-869a-374e4cab6129.jpg)
![select char pixel](https://user-images.githubusercontent.com/84968542/152483542-6a66bbb2-84b0-4ebd-97bd-3d4601d94a45.jpg)
![monsters pixel](https://user-images.githubusercontent.com/84968542/152483624-cd144bfe-fa5b-42a0-84a3-b04dcc7282e7.jpeg)


# GAME
This game uses the pixelated images from above as the assets. <br />
This is a game project built in Unity 2D. The game consists of a character whose task is to avoid the monsters.The game allows the user to jump over the enemies being spawned from left and right direction using the space bar and and walk in left and right directions using the D and A key respectively. The player will be able to select a different character, restart the game or just go back to the main page to start a fresh game.

