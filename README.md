# GenerateImage
This is C# web-based application that allows a user to create images using Generative AI.  In the backend, a Python script is called using Huggingface Models to generate the image display it back on the browser.
<bold>A few things to note:</bold>
- You will need Visual Studio IDE
- Install Python 3.10 or higher
- Huggingface access code (You can create a free account on Huggingface <a href="https://huggingface.co/">here</a>)
  - You will need to create a Huggingface access token and it in the Python script text2img_cmd.py in line 7 (replace <HUGGING_FACE_ACCESS_TOKEN> with your access token you generate on Huggingface):
    - i.e. access_token = "<HUGGING_FACE_ACCESS_TOKEN>"
- Line 35 of C# file in CreateImages\Pages\GenerateImage.cshtml.cs, you will need to replace text within the quotes to the path location of your installed Python executable.
