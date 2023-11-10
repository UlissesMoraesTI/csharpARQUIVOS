try
{
    string[] linhas = File.ReadAllLines("Arquivos/ArquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"ERRO: Arquivo não localizado no diretório. {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"ERRO: Diretório não localizado. {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally
{
    Console.WriteLine("Fechar Conexão...");
}
