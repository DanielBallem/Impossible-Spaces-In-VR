# Impossible-Spaces-In-VR
A small demonstration integrating stencil buffers and virtual reality, which allows the user to engage in impossible spaces.

## Showcase:
https://user-images.githubusercontent.com/33844493/214108688-31806d77-4a9d-44ff-a509-1ff5f0f56a6a.mp4

https://user-images.githubusercontent.com/33844493/214108858-3b51a644-e1c5-4f58-9844-c871dc71bc4e.mp4

## Technical Details:
- Combines Unity XR and the Unity's Universal Render Pipeline (URP) to utilize stencil masks.
- Objects exist within different interactable layers, and moving them between boundaries changes their layer.

## Limitations:
- Shadows are not masked to a layer, since shadows are calculated prior to masking. This means that shadows casted by objects on a different layer are still visible. In the demo, I have disabled shadows on objects that can be picked up. 
  - In a real project, baked lighting would be a perfect workaround for static environments. 
- Objects are still interactable / grabbable even if they aren't visible. This could actually be a good place to improve on the project, but the nuances of grabbing an object in this way is out of the scope for this project. 
