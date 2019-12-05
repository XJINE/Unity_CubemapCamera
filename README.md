# Unity_CubemapCamera

<img src="https://github.com/XJINE/Unity_CubemapCamera/blob/master/Screenshot.png" width="100%" height="auto" />

## Import to Your Project

You can import this asset from UnityPackage.

- [CubemapCamera.unitypackage](https://github.com/XJINE/Unity_CubemapCamera/blob/master/CubemapCamera.unitypackage)

### Dependencies

You have to import following assets to use this asset.

- [Unity_IInitializable](https://github.com/XJINE/Unity_IInitializable)

## How to Use

Add ``CubemapCamera.cs`` to camera object and set the parameters.

``CubemapCamera`` renders Cubemap in ``LateUpdate`` and you can get it from ``CubemapCamera.Cubemap`` property.