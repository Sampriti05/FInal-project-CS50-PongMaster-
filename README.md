# FInal-project-CS50-PongMaster-
# PongMaster!
#### Video Demo:  <https://youtu.be/UDgB-U1D_MQ>
#### Description: 

The main language used is C#.This game was developed through Unity. Scripts have been created for each sprite - player paddle, computer paddle, ball.Scripts were also created for Gamemanager, Bounciness of surface(for the top and bottom wall) and the Scorezones(for the left and right wall)

Left side panel of the game is the players paddle. Right side panel of the game is the Computer’s paddle. 
Your up and down arrow key in your keyboard will make the paddle move accordingly, this is a function set up using the code under the paddle. Player must hit the ball accurately in the center of the paddle for the point to count. After every point the ball will respawn at the center and the default positions of the paddle will also be at the center.

#### How does the point system work?:
If the ball hits the right wall a point goes to the player while if it hits the left wall a point goes to the computer
the score on the left panel indicates the player points while the score on the right panel indicates the score of the computer.

Other key mentions:

* A simple algorithm where the computer paddle follows the balls position is put into place through code -> it is made in such a way that the computer misses some balls too. 
* The 4 boundaries of the ball hitting the wall is placed through Unity 
* Paddles have gravity and drag set to them 
* The bounceback of the ball is set into place by a function called physics in Unity 
* If the ball hits the top and bottom wall it will proceed at a sharper angle as I have made the top and bottom walls to be bouncy via unity 


<img width="842" alt="Screenshot 2023-06-01 at 8 14 39 PM" src="https://github.com/Sampriti05/FInal-project-CS50-PongMaster-/assets/101947657/9deb220d-8756-4b67-8a49-45d0ce41c92d">
