using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using static CreateImages.Pages.IndexModel;


namespace CreateImages.Pages
{
    public class GenerateImageModel : PageModel
    {
        public readonly IConfiguration _configuration;
        public string page_input = "";

        public GenerateImageModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet()
        {
            page_input = Request.Query["text"].ToString();
            Console.Write("page_input : " + page_input);
            DoPython(page_input);
        }

        private static void DoPython(string inputText)
        {
            string cmd = "C:\\Users\\EarthVina\\PycharmProjects\\UsingHuggingFaceModel\\text2img_cmd.py";
            RunCommand(cmd, inputText);
        }

        private static void RunCommand(string cmd, string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:\\Users\\EarthVina\\PycharmProjects\\UsingHuggingFaceModel\\Scripts\\python.exe";
            start.Arguments = string.Format("{0} \"{1}\"", cmd, args);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;

            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }
        }
    }
}
