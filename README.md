# Unity_CubemapCamera

<img src="https://github.com/XJINE/Unity_CubemapCamera/blob/master/Screenshot.png" width="100%" height="auto" />

CubemapCamera just makes Cubemap RenderTexture.

## Import to Your Project

You can import this asset from UnityPackage.

- [CubemapCamera.unitypackage](https://github.com/XJINE/Unity_CubemapCamera/blob/master/CubemapCamera.unitypackage)

### Dependencies

You have to import following assets to use this asset.

- [Unity_IInitializable](https://github.com/XJINE/Unity_IInitializable)

## How to Use

Add ``CubemapCamera.cs`` to camera object and set the parameters.

``CubemapCamera`` renders Cubemap in ``LateUpdate`` and you can get it from ``CubemapCamera.Cubemap`` property.

### Resolution

<img src="https://github.com/XJINE/Unity_CubemapCamera/blob/master/Resolution.png" width="100%" height="auto" />

Resolution means the each square's resolution of Cubemap.