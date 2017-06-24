# KeyDisplay
A software for displaying all pressed keys and/or key combinations on screen. Written in C# .NET

Config.txt allows you to customize the standard settings of the program.
The syntax is as follows:
Key:Value

The following key/value pairs are recognized by the program:

FontFamily:[Microsoft Sans Serif, Arial, Helvetica etc.]
FontStyle:[Bold, Italic, Regular, Strikeout, Underline]
FontSize:[16,36,50 etc.]
Color:[#FF00FF, #123456, #FFFFFF]
DisplayTime:[In seconds, Any integer e.g. 1, 5, 2]

KeysConfig.txt allows you to specify a custom name displayed for each key.
The syntax is as follows:
Key Id:System given key name:Custom key name
