# CS:GO Stream Scoreboard
####About:
A live updating scoreboard for CS:GO streamers to show onscreen that shows kills, deaths, and assists. Uses CS:GO's built-in Game-state Integration. The program is highly customizable and extensible with the proper finesse and patience.

![Alt text](https://github.com/dechristopher/csgo-stream-scoreboard/res/scoreboard.png)

As seen in the picture above, the format of the displayed stats follows this diagram:
````
K [kills in current round] / [total kills in match] D [total deaths in match] A [total assists in match]
````

####Acquisition:
Compiled binaries can be found in the releases section above or through this link: [Releases Section](https://github.com/dechristopher/csgo-stream-scoreboard/releases)

####Usage instructions:
- Either compile or download a pre-compiled release of the program.
- (If downloaded, extract the executable and the settings file to a folder anywhere on your computer)
- Take the gamestate\_integration\_kda.cfg file either from this repository or the downloaded release.zip and place it in your CS:GO install folder in the /csgo/cfg folder (**DON'T** modify this file unless you know what you're doing)
- Find your SteamID 32 from http://steamid.co or wherever else and paste it into your settings.txt in place of <SteamID>
- Run the program and you should get no error messages. Hop ingame for some testing.
- If improperly configured, the program will tell you what's wrong in a pop-up window. Make sure your settings.txt follows the format as shown below.

####Configuration:
Some basic tweaking can be done in the settings.txt file to alter the appearance of your scoreboard. This is useful if you want to change the color of the taxt or make the background of the scoreboard easy to chroma-key. The default settings.txt file looks like the following:
````
<SteamID> 64 64 64 0 192 0
````
The format of the file consists of the following
````
            BG Color     Score Color
<SteamID> [<R> <G> <B>] [<R> <G> <B>]
````
All values in the file are separated by spaces.

For help with the RGB values, visit [THIS SITE](http://www.rapidtables.com/web/color/RGB_Color.htm)

####FAQ:
- Can I use this for my <insert whatever here>? **YES**
- Can I take code from this and use it in my application? **YES, but attribution is required**
- Can I modify this program and re-release it? **YES**
- Is it possible to add more stats to it? **YES** Read up on it [HERE](https://developer.valvesoftware.com/wiki/Counter-Strike:_Global_Offensive_Game_State_Integration)
