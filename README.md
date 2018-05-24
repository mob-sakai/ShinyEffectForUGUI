ShinyEffectForUGUI
===

### NOTE: This project has been merged to [UIEffect](https://github.com/mob-sakai/UIEffect).

Shiny effect without Mask commponent.  
Since useless draw calls are suppressed, performance is good!

![image](https://user-images.githubusercontent.com/12690315/40470027-4335bbf6-5f6d-11e8-8b8f-a130654d67db.png)

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

![compare](https://user-images.githubusercontent.com/12690315/40418786-39ad8b04-5ebe-11e8-91b9-2246a3d08a8c.gif)

* With-mask method
    * For example: ShineEffect from [unity-ui-extensions](https://bitbucket.org/UnityUIExtensions/unity-ui-extensions)
    * 3 GameObject: Graphic + Mask + ShineEffect (masked)
        * ![image](https://user-images.githubusercontent.com/12690315/38498601-ec56963e-3c3f-11e8-9eb4-4723389032f2.png)
    * At least 3 draw calls(1:Stencil on, 2:Draw graphic, 3:Stensil off), **FOR EACH** ui elements with shiny effect
    * **Artifacts on the edges!**  

* **Proposal:** Without-mask method
    * shader applies shiny effect
    * 1 draw dall
    * Will be batched as possible

<br><br>
##### Features

* No Mask component
* Easy to control in inspector  
![inspector](https://user-images.githubusercontent.com/12690315/40481130-65978b02-5f8b-11e8-90f3-02cf73107c4b.gif)
* Supports AnimationClip
* Will be batched as possible
* Play effect from script (v0.4.0)
    * `ShinyEffectForUGUI.Play(duration, updateMode)`  
    ![button](https://user-images.githubusercontent.com/12690315/40482409-a97b1a56-5f8f-11e8-819d-e75a40fd4fc5.gif)
* Improve Visual quality (v0.4.0)  
![image](https://user-images.githubusercontent.com/12690315/40473559-7416b086-5f77-11e8-97e4-d0de6137ea28.gif)
    * The effect does not use other images such as normal map.



<br><br><br><br>
## Demo

[WebGL Demo](http://mob-sakai.github.io/ShinyEffectForUGUI/)



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
