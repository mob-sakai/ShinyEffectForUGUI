ShinyEffectForUGUI
===

### NOTE: This project *will* be merged to [UIEffect](https://github.com/mob-sakai/UIEffect).

Shiny effect without Mask commponent.  
Since useless draw calls are suppressed, performance is good!

![4 -09-2018 22-45-47](https://user-images.githubusercontent.com/12690315/38501362-c56e3768-3c47-11e8-9ec1-50343d8b83ad.gif)

[![](https://img.shields.io/github/release/mob-sakai/ShinyEffectForUGUI.svg?label=latest%20version)](https://github.com/mob-sakai/ShinyEffectForUGUI/release)
[![](https://img.shields.io/github/release-date/mob-sakai/ShinyEffectForUGUI.svg)](https://github.com/mob-sakai/ShinyEffectForUGUI/releases)  
![](https://img.shields.io/badge/requirement-Unity%205.5%2B-green.svg)
[![](https://img.shields.io/github/license/mob-sakai/ShinyEffectForUGUI.svg)](https://github.com/mob-sakai/ShinyEffectForUGUI/blob/master/LICENSE.txt)  
[![](https://img.shields.io/github/last-commit/mob-sakai/ShinyEffectForUGUI/develop.svg?label=last%20commit)](https://github.com/mob-sakai/ShinyEffectForUGUI/commits/develop)
[![](https://img.shields.io/github/issues/mob-sakai/ShinyEffectForUGUI.svg)](https://github.com/mob-sakai/ShinyEffectForUGUI/issues)
[![](https://img.shields.io/github/commits-since/mob-sakai/ShinyEffectForUGUI/latest.svg)](https://github.com/mob-sakai/ShinyEffectForUGUI/compare/master...develop)


<< [Description](#Description) | [Demo](#demo) | [Download](https://github.com/mob-sakai/ShinyEffectForUGUI/releases) | [Usage](#usage) | [Development Note](#development-note) | [Change log](https://github.com/mob-sakai/ShinyEffectForUGUI/blob/develop/CHANGELOG.md) >>



<br><br><br><br>
## Description

ShinyEffectForUGUI applies _shiny-effect_ to uGUI element (Image, RawImage, Text, etc...) **WITHOUT Mask component** .  
This will suppress extra draw calls and improve performance.

![image](https://user-images.githubusercontent.com/12690315/38498655-16f9d766-3c40-11e8-8e47-4718d531c948.png)


* Without-mask method
    * Be applied shiny effect by shader
    * 1 draw dall
    * Will be batched as possible
* With-mask method
    * For example: ShineEffect from [unity-ui-extensions](https://bitbucket.org/UnityUIExtensions/unity-ui-extensions)
    * Graphic + Mask + ShineEffect (masked)
        * ![image](https://user-images.githubusercontent.com/12690315/38498601-ec56963e-3c3f-11e8-9eb4-4723389032f2.png)
    * At least 3 draw calls, **for each** ui elements with shiny effect
        * Stencil on
        * Draw graphic
        * Stensil off
    * Artifacts on the edges


<br><br><br><br>
## Demo

![4 -09-2018 23-15-12](https://user-images.githubusercontent.com/12690315/38503024-f1055fd8-3c4b-11e8-9065-841c75728498.gif)



<br><br><br><br>
## Usage

1. Download ShinyEffectForUGUI.unitypackage from [Releases](https://github.com/mob-sakai/ShinyEffectForUGUI/releases).
1. Import the package into your Unity project. Select `Import Package > Custom Package` from the `Assets` menu.
1. Add `ShinyEffectForUGUI` component to UI element (Image, RawImage, Text, etc...) from `Add Component` in inspector.
1. Choose effect type and adjust values in inspector.  
1. Enjoy!


##### Requirement

* Unity 5.5+ *(included Unity 2017.x)*
* No other SDK are required



<br><br><br><br>
## Development Note

#### What's doing?

* Control effect parameters for uGUI element WITHOUT MaterialPropertyBlock
    * https://github.com/mob-sakai/UIEffect#how-to-control-effect-parameters-for-ugui-element-without-materialpropertyblock
* Directivity normalization
    * Likely `Vector2.Product()`
* Linear shiny effect



<br><br><br><br>
## License

* MIT
* © UTJ/UCL



## Author

[mob-sakai](https://github.com/mob-sakai)



## See Also

* GitHub page : https://github.com/mob-sakai/ShinyEffectForUGUI
* Releases : https://github.com/mob-sakai/ShinyEffectForUGUI/releases
* Issue tracker : https://github.com/mob-sakai/ShinyEffectForUGUI/issues
* Current project : https://github.com/mob-sakai/ShinyEffectForUGUI/projects/1
* Change log : https://github.com/mob-sakai/ShinyEffectForUGUI/blob/master/CHANGELOG.md
