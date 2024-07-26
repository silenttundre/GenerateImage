# GenerateImage
This is C# web-based application that allows a user to enter the text of the image they want the application to generate.  In the backend, a Python script is called using Huggingface Models to generate the image display it back on the browser.
- Visual Studio IDE
- Huggingface access code (You can create a free account on Huggingface <a href="https://huggingface.co/">here</a>)
  - You will need to create a Huggingface access token and it in the Python script text2img_cmd.py in line 7 (replace <HUGGING_FACE_ACCESS_TOKEN> with your access token you generate on Huggingface):
    - i.e. access_token = "<HUGGING_FACE_ACCESS_TOKEN>"
- 
