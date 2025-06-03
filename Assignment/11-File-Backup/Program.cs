string file1 = @"test.txt";
File.Create(file1).Close();
string file2 = @"test.txt";
File.Create(file2).Close();
string file3 = @"test.txt";
File.Create(file3).Close();
string file4 = @"test.txt";
File.Create(file4).Close();

string progetto1 = @"test.txt";
Directory.CreateDirectory(progetto1);
string progetto2 = @"test.txt";
Directory.CreateDirectory(progetto2);


//string progetto = Path.Combine(Progetti, "Progetto1", "Progetto2","file1.txt", "file2.txt", "file3.txt", "file4.txt");
string progetto = Path.Combine(Fra_esercizio\Assignment\11-File-Backup\Progetti);
string destinazioneProgetto = DateTime.Now.ToString("yyyyMMdd_HHmmss");
if (Directory.Exists(progetto))
{
    Directory.Copy(progetto, destinazioneProgetto, true); 
}
else
{
    Console.WriteLine("Il file di origine non esiste.");
}




