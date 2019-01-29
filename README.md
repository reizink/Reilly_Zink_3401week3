# Reilly_Zink_3401week3
Game Development 1 lesson

*Game dev 1 review: OU class week by week*

In your Unity projects, make sure that your editor settings are set to “Visible Meta Files”
- Also set asset serialization to “Force Text” to ensure it play well with git
- Any UI element in Unity must be inside a canvas (added automatically if not present)
- UI elements are drawn in the same order they appear in the hierarchy
- Canvases can be rendered in Screen Space Overlay, Screen Space Camera, or World Space
- UI objects have a Rect Transform component, which overrides the default Transform component
- You can anchor UI elements to specific points to maintain relative positioning on various resolutions
- Unity provides many built-in UI objects, including buttons, sliders, toggles, and more
- You can hook up UI interactions to scripts or other functionality through the UI event system
- Objects like buttons have pre-built event listeners attached
- You can add interaction yourself via an Event Trigger component
- In Unity, audio is emitted from Audio Sources and received by Audio Listeners
- There can only be 1 active audio listener in a scene at any given time
- Audio sources can be configured to play 2D (flat) or 3D (directional) audio
- Audio can optionally be routed through Mixers, which can apply various effects to the audio
- You can configure mixers by opening the Audio Mixer window
