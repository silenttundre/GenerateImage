import requests
import os
import sys

EXIT_LOOP = ['quit','exit']

access_token = os.environ.get("HUGGING_FACE_KEY")
input_text = sys.argv[1]

#API_URL = "https://api-inference.huggingface.co/models/alvdansen/littletinies"
#API_URL = "https://api-inference.huggingface.co/models/cagliostrolab/animagine-xl-3.1"
API_URL = "https://api-inference.huggingface.co/models/stabilityai/stable-diffusion-3-medium-diffusers"
#API_URL = "https://api-inference.huggingface.co/models/runwayml/stable-diffusion-v1-5"  # Stable Diffusion is a latent text-to-image diffusion model capable of generating photo-realistic images given any text input.

header_str_val = f"Bearer {access_token}"

headers = {"Authorization": header_str_val}
print("\nLoading models...")
def query(payload):
	response = requests.post(API_URL, headers=headers, json=payload)
	return response.content
image_bytes = query({
	"inputs": input_text,
})

# You can access the image with PIL.Image for example
import io
from PIL import Image
image = Image.open(io.BytesIO(image_bytes))
print("Generating image...")
image.save("wwwroot/images/gen_img.jpg")
#image.show()
print("Done.")
