# HW2-CS410
HW2 including dot product, lerp, particles, sounds

Dot product/Sound: I used vector subtraction and length to calculate the distance from the player to the finish location. When the player gets within 10 distance of the finish location it plays a custom alert sound that tells the player the exit is nearby. The sound is a free sound asset I found and the trigger is when the player is within the distance calculated. This can be found in the NearAudio script. 


LERP/particles: I added custom particles that are triggered when the player gets within a short distance of the Gargoyle (also calculated with vector sub/len). I used linear interpolation to gradually shift the color of the particles from black to red.
