# GenerateImage
This is C# web-based application that allows a user to create images using Generative AI.  In the backend, a Python script is called using Huggingface Models to generate the image display it back on the browser.

<bold>A few things to note:</bold>
- You will need Visual Studio IDE
- Install Python 3.10 or higher
- Huggingface access code (You can create a free account on Huggingface <a href="https://huggingface.co/">here</a>)
  - You will need to create a Huggingface access token and it in the Python script text2img_cmd.py in line 7 (replace <HUGGING_FACE_ACCESS_TOKEN> with your access token you generate on Huggingface):
    - i.e. access_token = "<HUGGING_FACE_ACCESS_TOKEN>"
- Line 35 of C# file in CreateImages\Pages\GenerateImage.cshtml.cs, you will need to replace text within the quotes to the path location of your installed Python executable.

To run the web application:
1) Open the CreateImages.sln file with Visual Studio
2) Click the green play button just under the "Tools" menu to start the app ![image](https://github.com/user-attachments/assets/97ec9c64-7685-4800-a161-2a223402f8b9)
3) It should look like this when the web browser pops up:
<p>
 ![image](https://github.com/user-attachments/assets/63420dce-f866-42b2-80ed-3cdc40930249)
</p>
4) Type your text and press <Enter> key or click on the <Generate> button.
