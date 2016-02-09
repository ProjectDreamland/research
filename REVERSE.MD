### This file will contain all findings on my reverse engineering adventures of Area 51


A51.dll does nothing, it was probably drm at some point, not loaded into the assembly can be removed entirely.

### Models 

models are stored in multiple strips of vertexes:
verX, verY, verZ CONN, where the vertexes are 4byte floating points and CONN could be either 00 00 00 00 or 00 80 00 00, or 20 00 00 00. 00 80 00 00 always comes in pairs of two.

The vertexes are connected in triplets for every vertex except for when 00 80 00 00 occur in the last of the three consequent vertexes.

Stored as .NMP (Appearntly) 



### Audio

Mixture of RAW data and Mp3, RAW data being used for mostly everything.


### FXO

Precompiled shaders




### Textures/Images

Stored as .xbmp. See tools for method of conversion/back 


### Unpacking Archives




### Repacking Archives




