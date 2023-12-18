using System.Diagnostics; 

HttpClient client = new HttpClient(); 
HttpResponseMessage response = await client.GetAsync("https://rur.hitmotop.com/song/64401882"); 
byte[] data = response.Content.ReadAsByteArrayAsync().Result; 
File.WriteAllBytes("//Users/sofass/Desktop/serye-glaza.mp3"); 

Process.Start(new ProcessStartInfo { FileName = "//Users/sofass/Desktop/serye-glaza.mp3", UseShellExecute = true });