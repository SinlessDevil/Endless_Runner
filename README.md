# Endless_Runner
Simple 2D Endless Runner (Blackthornprod)

In this repository I decided to make a clone of the BlackthornProd runner - https://github.com/BlackthornProd/EndlessRunnerSeries
With a complete redesign of the code

![Image alt](https://github.com/SinlessDevil/Endless_Runner/blob/main/Слой_1.png)
![Image alt](https://github.com/SinlessDevil/Endless_Runner/blob/main/Слой_2.png)

The first thing I did was rework the character.
A lot of unnecessary code in Update + violation of Single-responsibility principle. That's why I divided the logic into three classes. 
(Character, Controller, Character Health)

![Image alt](https://github.com/SinlessDevil/Endless_Runner/blob/main/SIP_(OOP)_Player.png)

Then I took up the background, since it creates a new vector 3 in UpDate, I decided to use the Flyweight pattern
Flyweight is a structural design pattern that allows programs to support a huge number of objects while keeping memory consumption low.

![Image alt](https://github.com/SinlessDevil/Endless_Runner/blob/main/Parallax_Pattern_Flyweight.png)

At the same time, I decided to add buttons via Action. 
Thus sedlal so that the buttons do not depend on the character 
(in the future it may help you if you want to spawn a certain character or make multiplayer), as well skril methods from the buttons.

![Image alt](https://github.com/SinlessDevil/Endless_Runner/blob/main/Button.png)

I played around with the health and goggle displays.
Used the pattern Observer. 
Observer - is a behavioral design pattern that allows some objects to notify other objects of changes in their state.
The Observer model provides the ability to subscribe to and unsubscribe from these events for any object that implements a subscriber interface.

![Image alt](https://github.com/SinlessDevil/Endless_Runner/blob/main/Pattern_Observal.png)

After health, I decided that it was time to deal with the enemies.
First of all, again, I tried to separate the logic and responsibility of the component.
Gave up tags, because it is not very convenient.
Secondly, because I want to get rid of destroy and instantiate in the future. I decided to just switch the object on and return it to the starting position.

Note : whenever I get a component using GetComponnet, 
I recommend using Requirecomponent to avoid throwing an exception if the object is not found or something like that.

![Image alt](https://github.com/SinlessDevil/Endless_Runner/blob/main/Enemy.png)

Next up was Score. Again, divided the logic in two scripts, roughly speaking on the UI and Collision. But here I decided to add a little bit of my own, and decided that I would have different enemies. And from each enemy will be different points. I started to use the Visitor patch, you could say I took the switch out of the code.

Visitor is a behavioral design pattern that allows adding new behaviors to existing class hierarchy without altering any existing code.

![Image alt](https://github.com/SinlessDevil/Endless_Runner/blob/main/Score_Patter_Visit.png)
![Image alt](https://github.com/SinlessDevil/Endless_Runner/blob/main/Enemy_Visit.png)

And then the most important became the Spawner. Completely abandoned instanshient and destory in favor of Objects Pool.
Also decided to remove timer and use native coroutine.

I think it's better to use asynchronous code, but I decided to use coroutines

![Image alt](https://github.com/SinlessDevil/Endless_Runner/blob/main/Poor_Spawner.png)
![Image alt](https://github.com/SinlessDevil/Endless_Runner/blob/main/Pool_Mono.png)

Finally, I decided to use the state machine
The essence of the state machine is that the object cannot be in two states at the same time
![Image alt](https://github.com/SinlessDevil/Endless_Runner/blob/main/State_Machine.png)

In general, that's how my code came out, it's very far from done. But I think that this variant in principle has the right to exist =)
I wanted to make it more readable, reusable. I also took care of the performance.

I already made a similar game and uploaded it to Google Play =)

https://play.google.com/store/apps/details?id=com.EugeneCompany.UnderWaterWorld&hl=ru&gl=US

https://www.youtube.com/watch?v=xGs4pgig1JA
