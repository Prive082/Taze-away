# Taze-away
SharpDevelop C# code designed to activate taser via a relay when vocal triggers are spoken.  

# C# Code Summary
The code utilizes the internal computer microphone and a speech-to-text library in order to translate spoken work into a comparable string that can then compare itself to whatever strings are written in the list. The code when it detects a matching string writes a message for the arduino to receive. 

# Arduino Code Summary
The code when it receives the message from the SharpDevelop environment it opens the relay for half of a second to the corresponding pins written in the code, leading to an electric shock administered by whatever taser unit is plugged in to the relay and to the arduino for power. 
