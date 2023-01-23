# Impossible-Spaces-In-VR
A small demonstration integrating stencil buffers and virtual reality, which allows the user to engage in impossible spaces.

## Showcase:
https://user-images.githubusercontent.com/33844493/214150369-1d5419df-7c9d-48f1-a441-2e1d59aebec6.mp4

https://user-images.githubusercontent.com/33844493/214150408-9cf50e90-2c12-432f-b0d0-1ab1aa1707e3.mp4

https://user-images.githubusercontent.com/33844493/214150670-92f20414-7fcd-4a9a-94ea-b0f1fc5f895a.mp4




## Technical Details:
- Combines Unity XR and the Unity's Universal Render Pipeline (URP) to utilize stencil masks.
- Objects exist within different physical and rendering layers, and moving them between boundaries changes their layer.

## Limitations:
- Shadows are not masked to a layer, since shadows are calculated prior to masking. This means that shadows casted by objects on a different layer are still visible. In the demo, I have disabled shadows on objects that can be picked up. 
  - In a real project, baked lighting would be a perfect workaround for static environments. 
- Objects are still interactable / grabbable even if they aren't visible. This could actually be a good place to improve on the project, but the nuances of grabbing an object in this way is out of the scope for this project. 
